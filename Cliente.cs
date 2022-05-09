using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public int Assento { get; set; }

        public Cliente(string nome, int assento)
        {
            Nome = nome;
            Assento = assento;
        }
    }
}
