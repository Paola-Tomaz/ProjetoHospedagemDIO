<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagemDIO.Models;

public class Suite
{
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite()
        {
        }
=======
namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }
>>>>>>> 918e80bed408d6d49de00e138359d248dc0237fc

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
<<<<<<< HEAD
}
=======

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
>>>>>>> 918e80bed408d6d49de00e138359d248dc0237fc
