# Desafio de Projeto: Sistema de Hospedagem

Este repositório contém a implementação do desafio de projeto proposto pela **DIO (Digital Innovation One)** na trilha .NET, no módulo **Explorando a Linguagem C#**. O objetivo do projeto é construir um sistema de hospedagem para gerenciamento de reservas em hotéis.

## 🏨 Contexto

Você foi contratado para desenvolver um sistema de hospedagem que realiza reservas de suítes para hóspedes. O sistema utiliza três classes principais:

- **Pessoa**: Representa o hóspede.
- **Suíte**: Representa a acomodação.
- **Reserva**: Faz o relacionamento entre os hóspedes e a suíte, além de calcular os valores associados à reserva.

## ✨ Funcionalidades

1. **Cadastro de Hóspedes e Suítes**:
   - Criação de hóspedes utilizando a classe `Pessoa`.
   - Cadastro de suítes com capacidade e valor da diária.

2. **Gerenciamento de Reservas**:
   - Associação entre hóspedes e suítes.
   - Cálculo do valor total da reserva com desconto para estadias longas.

3. **Regras de Validação**:
   - Não é permitido realizar uma reserva se o número de hóspedes exceder a capacidade da suíte.
   - O método `ObterQuantidadeHospedes` retorna o número total de hóspedes.
   - O método `CalcularValorDiaria` calcula o valor total da estadia (número de dias reservados x valor da diária).
   - Um desconto de **10%** é aplicado para reservas de **10 dias ou mais**.

## ✅ Requisitos

- **Regra 1**: O número de hóspedes não pode ultrapassar a capacidade da suíte. Se isso ocorrer, o sistema deve lançar uma exceção.
- **Regra 2**: Reservas de 10 dias ou mais recebem um desconto automático de 10% no valor total.

## 💻 Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET

## 🚀 Como Executar

1. Clone o repositório:
   ```bash
   git clone [https://github.com/Paola-Tomaz/ProjetoHospedagemDIO.git]
    ```

2. **Navegue até o diretório do projeto**:
   ```bash
   cd DesafioProjetoHospedagemDIO
   ```
   
3. **Compile e execute o projeto**:
   ```bash
   dotnet run
    ```
   
## 📂 Estrutura do Projeto

```plaintext
📁 DesafioProjetoHospedagemDIO
├── 📂 Models
│   ├── Pessoa.cs
│   ├── Suite.cs
│   └── Reserva.cs
├── Program.cs
├── DesafioProjetoHospedagemDIO.csproj
```
## 🤝 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

---

Desenvolvido por [Paola](https://github.com/Paola-Tomaz) durante a trilha .NET da DIO.

