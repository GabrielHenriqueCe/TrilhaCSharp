using ClasseListaMetodo.Rep5.Mochila;
using ClasseListaMetodo.Rep5.Mochila.Exceptions;

Mochila mochila = new Mochila(10);

List<Item> itens = new List<Item>
{
    new ("Poção", 1),
    new ("Espada", 4),
    new ("Escudo", 5),
    new ("Corda", 2)
};

void ListarItens()
{
    for (int i = 0; i < itens.Count; i++)
    {

        Console.WriteLine($"{i + 1} - " + itens[i].DescreverItem());
    }
}

void ListarItensNaMochila()
{
    if (mochila.Itens.Count == 0)
    {
        Console.WriteLine("Nenhum item na mochila!");
        return;
    }
    else
    {
        Console.WriteLine("Itens na mochila: ");
        for (int i = 0; i < mochila.Itens.Count; i++)
        {
            Console.WriteLine($"{i + 1} - " + mochila.Itens[i].DescreverItem());
        }
    }
}

bool sair = false;
while (!sair)
{
    Console.Clear();
    Console.WriteLine("1 - Ver Mochila");
    Console.WriteLine("2 - Guardar Item");
    Console.WriteLine("3 - Tirar Item");
    Console.WriteLine("0 - Sair");

    Console.Write("\nEscolha uma opção: ");

    string escolha = Console.ReadLine() ?? "";
    switch (escolha)
    {
        case "1":
            Console.WriteLine(mochila.DescreverMochila());
            ListarItensNaMochila();
            break;
        case "2":
            try
            {
                ListarItens();
                Console.Write("\nEscolha um dos itens para Guardar: ");

                int escolherItem = 0;

                if (!int.TryParse(Console.ReadLine(), out escolherItem))
                {
                    Console.WriteLine("Digite um número.");
                    break;
                }

                if (escolherItem > itens.Count || escolherItem <= 0)
                    throw new RangeDaEscolhaException(itens);

                escolherItem--;
                string nomeDoItem = itens[escolherItem].Nome;
                mochila.GuardarItem(itens[escolherItem]);
                itens.Remove(itens[escolherItem]);
                Console.WriteLine(mochila.DescreverGuardar(nomeDoItem));

            }
            catch (RangeDaEscolhaException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (LimiteDePesoException erro)
            {
                Console.WriteLine(erro.Message);
            }
            break;
        case "3":
            try
            {
                ListarItensNaMochila();
                if (mochila.Itens.Count == 0)
                {
                    break;
                }
                Console.Write("\nEscolha um dos itens para Remover: ");

                int escolherItemDaMochila = 0;

                if (!int.TryParse(Console.ReadLine(), out escolherItemDaMochila))
                {
                    Console.WriteLine("Digite um número.");
                    break;
                }

                if (escolherItemDaMochila > mochila.Itens.Count || escolherItemDaMochila <= 0)
                    throw new RangeDaEscolhaException(mochila.Itens);

                escolherItemDaMochila--;
                string nomeDoItem = mochila.Itens[escolherItemDaMochila].Nome;

                itens.Add(mochila.Itens[escolherItemDaMochila]);
                mochila.RemoverItem(mochila.Itens[escolherItemDaMochila]);
                Console.WriteLine(mochila.DescreverRemocao(nomeDoItem));
            }
            catch (RangeDaEscolhaException erro)
            {
                Console.WriteLine(erro.Message);
            }
            break;
        case "0":
            Console.WriteLine("Obrigado por organizar a Mochila, volte sempre!");
            sair = true;
            break;
        default:
            Console.WriteLine("\nEscolha uma opção válida");
            break;
    }

    if (sair == false)
    {
        Console.WriteLine("\nDigite Enter para Continuar");
        Console.ReadLine();
    }
}