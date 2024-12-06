<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagemDIO.Models;
public class Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    public Pessoa()
    {
    }
=======
namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }
>>>>>>> 918e80bed408d6d49de00e138359d248dc0237fc

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
<<<<<<< HEAD
}
=======

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}
>>>>>>> 918e80bed408d6d49de00e138359d248dc0237fc
