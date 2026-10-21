namespace ClasseListaMetodo.Rep4.Missoes.Exceptions
{
    public class NivelAbaixoDoNecessarioException : Exception
    {
        public NivelAbaixoDoNecessarioException(Heroi heroi, Missao missao) : base($"Recusada: {missao.Nome} pede nível {missao.NivelMinimo}, {heroi.Nome} está no nível {heroi.Nivel}") { }
    }
}
