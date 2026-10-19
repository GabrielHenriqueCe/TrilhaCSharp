namespace ClasseListaMetodo.Rep3.Loja.Exceptions
{
    internal class MenorQueZeroException : Exception
    {
        public MenorQueZeroException() : base("O valor não pode ser menor que Zero.") { }
    }
}
