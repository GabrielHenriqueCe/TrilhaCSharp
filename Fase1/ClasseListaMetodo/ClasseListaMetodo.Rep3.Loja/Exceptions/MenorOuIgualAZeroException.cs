namespace ClasseListaMetodo.Rep3.Loja.Exceptions
{
    internal class MenorOuIgualAZeroException : Exception
    {
        public MenorOuIgualAZeroException() : base("O valor não pode ser menor ou igual a Zero.") { }
    }
}
