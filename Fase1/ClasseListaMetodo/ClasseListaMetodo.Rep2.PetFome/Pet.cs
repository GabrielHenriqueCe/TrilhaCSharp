namespace ClasseListaMetodo.Rep2.PetFome
{
    public class Pet
    {
        public string Nome { get; private set; }
        private int _fome;

        public int Fome
        {
            get { return _fome; }
            private set
            {
                if (value < 0) _fome = 0;
                else if (value > 100) _fome = 100;
                else _fome = value;
            }
        }

        public Pet(string nome)
        {
            Nome = nome;
            Fome = 100;
        }

        public void PassarTurno()
        {
            Fome -= 10;
        }

        public void Alimentar()
        {
            Fome += 30;
        }

        public string FichaDoPet()
        {
            return $"Nome: {Nome}   Fome: {Fome}/100";
        }
    }
}
