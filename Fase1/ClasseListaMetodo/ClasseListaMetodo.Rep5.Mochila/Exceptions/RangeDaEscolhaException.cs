using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseListaMetodo.Rep5.Mochila.Exceptions
{
    public class RangeDaEscolhaException : Exception
    {
        public RangeDaEscolhaException(List<Item> itens) : base($"Escolha  entre 1 e {itens.Count}") { }
    }
}
