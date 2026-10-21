using ClasseListaMetodo.Rep4.Missoes.Exceptions;
using System.Reflection;

namespace ClasseListaMetodo.Rep4.Missoes
{
    public class Heroi
    {
        private int _nivel;
        private int _xp;

        public string Nome { get; private set; }
        public int Nivel
        {
            get { return _nivel; }
            private set
            {
                _nivel = value <= 0 ? throw new MenorOuIgualAZeroException() : value;
            }
        }

        public int XP
        {
            get { return _xp; }
            private set
            {
                _xp = value < 0 ? throw new MenorQueZeroException() : value;
            }
        }

        public Heroi(string nome)
        {
            Nome = nome;
            Nivel = 1;
            XP = 0;
        }

        public void FazerMissao(Missao missao)
        {
            if (missao.MissaoConcluida)
                throw new MissaoJaConcluidaException(missao);
            if (Nivel < missao.NivelMinimo)
                throw new NivelAbaixoDoNecessarioException(this, missao);
            missao.ConcluirMissao();
            Upar(missao);
        }

        private void Upar(Missao missao)
        {
            int xp = XP + missao.XpRecompensa;
            XP = xp % 100;
            Nivel += xp / 100;
        }

        public string FichaDoHeroi()
        {
            return $"Nome: {Nome}   Nivel: {Nivel}     XP: {XP}";
        }
    }
}
