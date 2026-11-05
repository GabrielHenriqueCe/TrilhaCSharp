namespace ClasseListaMetodo.Rep5.Mochila.Exceptions
{
    public class LimiteDePesoException : Exception
    {
        public LimiteDePesoException(Mochila mochila, Item item) : base($"Recusado: {item.Nome} pesa {item.Peso} só cabe mais  {mochila.CapacidadeDePeso - mochila.PesoAtual}") { }
    }
}
