using ClasseListaMetodo.Rep5.Mochila.Exceptions;

namespace ClasseListaMetodo.Rep5.Mochila
{
    public class Item
    {
        public string Nome { get; private set; }
        private int _peso;
        public int Peso
        {
            get { return _peso; }
            private set
            {
                _peso = value <= 0 ? throw new MenorOuIgualAZeroException() : value;
            }
        }

        public Item(string nome, int peso)
        {
            Nome = nome;
            Peso = peso;
        }

        public string DescreverItem()
        {
            return $"Nome: {Nome}       Peso: {Peso}";
        }
    }
}