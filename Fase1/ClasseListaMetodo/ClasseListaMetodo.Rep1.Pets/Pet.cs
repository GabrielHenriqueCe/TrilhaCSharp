namespace ClasseListaMetodo.Rep1.Pets
{
    public class Pet
    {
        public string Nome { get; private set; }
        public string Especie { get; private set; }
        private int _nivel;

        public int Nivel
        {
            get { return _nivel; }
            private set => _nivel = value > 0 ? value : 1;
        }

        public Pet(string nome, string especie, int nivel)
        {
            Nome = nome;
            Especie = especie;
            Nivel = nivel;
        }

        public string FichaDoPet()
        {
            return $"Nome: {Nome} Espécie: {Especie} Nivel: {Nivel}";
        }
    }
}
