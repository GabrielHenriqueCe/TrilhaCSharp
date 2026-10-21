using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseListaMetodo.Rep4.Missoes.Exceptions
{
    public class RangeDaEscolhaException : Exception
    {
        public RangeDaEscolhaException(List<Missao> missoes) : base($"A escolha deve ser entre 1 e {missoes.Count}") { }
    }
}
