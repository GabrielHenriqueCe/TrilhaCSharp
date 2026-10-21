using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseListaMetodo.Rep4.Missoes.Exceptions
{
    public class MenorQueZeroException : Exception
    {
        public MenorQueZeroException() : base("O valor não pode ser menor que Zero") { }
    }
}
