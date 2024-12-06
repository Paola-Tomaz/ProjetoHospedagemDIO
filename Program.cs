using DesafioProjetoHospedagemDIO;
using DesafioProjetoHospedagemDIO.Models;

List<Suite> listaSuites = new List<Suite>();
List<Reserva> listaReservas = new List<Reserva>();

Reserva reserva = new Reserva();

while (true)
{
    try
    {
        Console.WriteLine("\n******* Wind Hotel System ********");
        Console.WriteLine("1. Consultar suítes disponíveis");
        Console.WriteLine("2. Realizar uma reserva");
        Console.WriteLine("3. Consultar lista de hóspedes");
        Console.WriteLine("4. Calcular valor da reserva");
        Console.WriteLine("5. Cadastrar nova suíte");
        Console.WriteLine("6. Sair\n");

        Console.WriteLine("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                if (listaSuites.Count == 0)
                {
                    Console.WriteLine("Nenhuma suíte cadastrada.");
                }
                else
                {
                    Console.WriteLine("\nSuítes disponíveis: ");
                    foreach (var suite in listaSuites)
                    {
                        Console.WriteLine($"- Suíte {suite.TipoSuite}: Capacidade {suite.Capacidade}, Diária R${suite.ValorDiaria:F2}");
                    }
                }
                break;

            case 2:
                if (listaSuites.Count == 0)
                {
                    Console.WriteLine("\nNenhuma suíte cadastrada para realizar reservas!");
                    break;
                }

                Console.WriteLine("\nEscolha a suíte pelo nome (Basic, Premium, Master):");
                string nomeSuiteConsulta = Console.ReadLine()?.Trim();

                Suite suiteEscolhida = listaSuites.Find(s => s.TipoSuite.Equals(nomeSuiteConsulta, StringComparison.OrdinalIgnoreCase));

                if (suiteEscolhida == null)
                {
                    Console.WriteLine("Suíte não encontrada!");
                    break;
                }

                Reserva novaReserva = new Reserva();
                novaReserva.CadastrarSuite(suiteEscolhida);

                Console.WriteLine("Quantos dias de reserva?");
                novaReserva.DiasReservados = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantos hóspedes?");
                int quantidadeHospedes = int.Parse(Console.ReadLine());

                List<Pessoa> hospedes = new List<Pessoa>();
                for (int i = 0; i < quantidadeHospedes; i++)
                {
                    Console.WriteLine($"Digite o nome do hóspede {i + 1}:");
                    hospedes.Add(new Pessoa(Console.ReadLine()));
                }

                try
                {
                    novaReserva.CadastrarHospedes(hospedes);
                    listaReservas.Add(novaReserva);
                    Console.WriteLine("Reserva realizada com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao cadastrar hóspedes: {ex.Message}");
                }
                break;

            case 3:
                if (listaReservas.Count == 0)
                {
                    Console.WriteLine("\nNenhuma reserva cadastrada para consultar hóspedes!");
                    break;
                }

                Console.WriteLine("\nSelecione a reserva pelo nome da suíte para consultar os hóspedes:");
                foreach (var r in listaReservas)
                {
                    Console.WriteLine($"- Suíte {r.Suite.TipoSuite}: {r.DiasReservados} dias, {r.Hospedes.Count} hóspede(s)");
                }

                string nomeSuiteConsultaLista = Console.ReadLine()?.Trim();
                Reserva reservaParaConsulta = listaReservas.Find(r => r.Suite.TipoSuite.Equals(nomeSuiteConsultaLista, StringComparison.OrdinalIgnoreCase));

                if (reservaParaConsulta == null)
                {
                    Console.WriteLine("Reserva não encontrada!");
                    break;
                }

                Console.WriteLine("\nLista de Hóspedes:");
                if (reservaParaConsulta.Hospedes.Count == 0)
                {
                    Console.WriteLine("Nenhum hóspede cadastrado nessa reserva!");
                }
                else
                {
                    foreach (var hospede in reservaParaConsulta.Hospedes)
                    {
                        Console.WriteLine($"- {hospede.Nome}");
                    }
                }

                break;

            case 4:
                if (listaReservas.Count == 0)
                {
                    Console.WriteLine("\nNenhuma reserva cadastrada para calcular o valor!");
                    break;
                }

                Console.WriteLine("\nSelecione a reserva pelo tipo de suíte:");
                foreach (var r in listaReservas)
                {
                    Console.WriteLine($"- Suíte {r.Suite.TipoSuite}: {r.DiasReservados} dias, {r.Hospedes.Count} hóspede(s)");
                }

                string tipoReserva = Console.ReadLine();
                Reserva reservaSelecionada = listaReservas.Find(r => r.Suite.TipoSuite.Equals(tipoReserva, StringComparison.OrdinalIgnoreCase));

                if (reservaSelecionada == null)
                {
                    Console.WriteLine("Reserva não encontrada!");
                    break;
                }

                try
                {
                    decimal valorTotal = reservaSelecionada.CalcularValorDiaria();
                    Console.WriteLine($"Valor total da reserva para a suíte {reservaSelecionada.Suite.TipoSuite}: R${valorTotal:F2}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }

                break;

            case 5:
                Console.WriteLine("\nDigite o tipo da suíte (Basic, Premium, Master): ");
                string tipoNovaSuite = Console.ReadLine()?.Trim();

                Console.WriteLine("Digite a capacidade da suíte: ");
                int capacidadeNovaSuite = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da diária da suíte: ");
                decimal valorDiariaNovaSuite = decimal.Parse(Console.ReadLine());

                try
                {
                    var suite = new Suite(tipoNovaSuite, capacidadeNovaSuite, valorDiariaNovaSuite);
                    listaSuites.Add(suite);

                    Console.WriteLine($"Nova suíte '{suite.TipoSuite}' cadastrada com sucesso!");

                    Console.WriteLine("\nSuítes cadastradas:");
                    foreach (var s in listaSuites)
                    {
                        Console.WriteLine($"- {s.TipoSuite}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao cadastrar a suíte: {ex.Message}");
                }
                break;

            case 6:
                return;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Erro de formato: {ex.Message}. Por favor insira os dados corretamente.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }

}