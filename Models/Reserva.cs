
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagemDIO.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva()
    {
    }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite == null)
            throw new InvalidOperationException("Nenhuma suíte foi cadastrada. Cadastre uma suíte antes de adicionar hóspedes.");

        if (hospedes.Count > Suite.Capacidade)
            throw new ArgumentException("A quantidade de hóspedes ultrapassa a capacidade permitida na suíte.");

        Hospedes = hospedes;

    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        if (Suite == null)
            throw new InvalidOperationException("Nenhuma suíte foi cadastrada.");


        decimal valorTotal = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= 10)
            valorTotal *= 0.1M;

        return valorTotal;
    }
}