using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagemDIO.Models;
public class Pessoa
{
    private string v;

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    public Pessoa()
    {
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public Pessoa(string v)
    {
        this.v = v;
    }
}
    
