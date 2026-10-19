using ClasseListaMetodo.Rep3.Loja.Exceptions;

namespace ClasseListaMetodo.Rep3.Loja
{
    public class Item
    {
        public string Nome { get; private set; }
        private decimal _preco;
        private int _estoque;

        public decimal Preco
        {
            get { return _preco; }
            private set
            {
                _preco = value < 0 ? throw new MenorQueZeroException() : value;
            }
        }

        public int Estoque
        {
            get { return _estoque; }
            private set
            {
                _estoque = value < 0 ? throw new MenorQueZeroException() : value;
            }
        }

        public Item (string nome, decimal preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void Vender (int quantidade)
        {
            if (quantidade <= 0)
                throw new MenorOuIgualAZeroException();
            else if (quantidade > Estoque)
                throw new MaiorQueEstoqueException(this);
            Estoque -= quantidade;
        }

        public void ReporEstoque (int quantidade)
        {
            if (quantidade <= 0)
                throw new MenorOuIgualAZeroException();
            Estoque += quantidade;
        }

        public string DescricaoItem()
        {
            return $"Nome: {Nome}     Preço: {Preco}     Quantidade em Estoque: {Estoque}";
        }
    }
}
