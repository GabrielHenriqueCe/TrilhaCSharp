using ClasseListaMetodo.Rep4.Missoes.Exceptions;

namespace ClasseListaMetodo.Rep4.Missoes
{
    public class Missao
    {
        private int _nivelMinimo;
        private int _xpRecompensa;
        public string Nome { get; private set; }
        public bool MissaoConcluida { get; private set; }
        public string StatusDaMissao
        {
            get { return MissaoConcluida ? "Missao Concluída" : "Missao Disponivel"; }
        }
        public int NivelMinimo
        {
            get { return _nivelMinimo; }
            private set
            {
                _nivelMinimo = value <= 0 ? throw new MenorOuIgualAZeroException() : value;
            }
        }
        public int XpRecompensa
        {
            get { return _xpRecompensa; }
            private set
            {
                _xpRecompensa = value <= 0 ? throw new MenorOuIgualAZeroException() : value;
            }
        }

        public Missao(string nome, int nivelMinimo, int xpRecompensa)
        {
            Nome = nome;
            NivelMinimo = nivelMinimo;
            XpRecompensa = xpRecompensa;
            MissaoConcluida = false;
        }

        public void ConcluirMissao()
        {
            MissaoConcluida = true;
        }

        public string FichaDaMissao()
        {
            return $"Nome: {Nome} \nNivel Minimo: {NivelMinimo} \nXP da Recompensa: {XpRecompensa} \nStatus da Missão: {StatusDaMissao}";
        }
    }
}