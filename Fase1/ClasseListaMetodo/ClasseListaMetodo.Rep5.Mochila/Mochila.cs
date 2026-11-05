using ClasseListaMetodo.Rep5.Mochila.Exceptions;
using System.Runtime.CompilerServices;

namespace ClasseListaMetodo.Rep5.Mochila
{
    public class Mochila
    {
        private int _capacidadeDePeso;
        private List<Item> _itens = new List<Item>();
        public List<Item> Itens => _itens;
        public int PesoAtual
        {
            get { return Itens.Sum(peso => peso.Peso); }
        }

        public int CapacidadeDePeso
        {
            get { return _capacidadeDePeso; }
            private set
            {
                _capacidadeDePeso = value <= 0 ? throw new MenorOuIgualAZeroException() : value;
            }
        }

        public Mochila(int capacidadeDePeso)
        {
            CapacidadeDePeso = capacidadeDePeso;
        }

        public void GuardarItem(Item item)
        {
            var peso = PesoAtual + item.Peso;
            if (peso > CapacidadeDePeso)
            {
                throw new LimiteDePesoException(this, item);
            }
            else
                Itens.Add(item);
        }

        public void RemoverItem(Item item)
        {
            Itens.Remove(item);
        }

        public string DescreverMochila()
        {
            return $"Peso: {PesoAtual} / {CapacidadeDePeso}\n";
        }

        public string DescreverRemocao(string nomeDoItem)
        {
            return $"Retirou: {nomeDoItem}      Peso Atual: {PesoAtual}";
        }
        public string DescreverGuardar(string nomeDoItem)
        {
            return $"Guardou: {nomeDoItem}      Peso Atual: {PesoAtual}";
        }
    }
}
