using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseListaMetodo.Rep4.Missoes.Exceptions
{
    public class MenorOuIgualAZeroException : Exception
    {
        public MenorOuIgualAZeroException() : base("O valor não pode ser menor ou igual a Zero") { }
    }
}
