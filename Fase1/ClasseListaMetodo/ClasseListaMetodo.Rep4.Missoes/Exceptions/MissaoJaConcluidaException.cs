using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseListaMetodo.Rep4.Missoes.Exceptions
{
    public class MissaoJaConcluidaException : Exception
    {
        public MissaoJaConcluidaException(Missao missao) : base($"{missao.Nome} ja está concluída!") { }
    }
}
