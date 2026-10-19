using ClasseListaMetodo.Rep3.Loja;
using ClasseListaMetodo.Rep3.Loja.Exceptions;

var itens = new List<Item>()
{
    new Item ("Ração", 4.99m, 10),
    new Item ("Poção", 12.50m, 5),
    new Item ("Ovo Raro", 49.99m, 0)
};

void VerItens()
{
    for (int i = 0; i < itens.Count; i++)
    {
        Console.WriteLine($"{i + 1} - " + itens[i].DescricaoItem());
    }
}

Item EscolherItem(List<Item> itens, int escolha)
{
    if (escolha <= 0)
        throw new MenorOuIgualAZeroException();
    else if (escolha > itens.Count)
        throw new LimiteDeEscolhaException(itens);
    else
        return itens[escolha - 1];
}

int TryParseComMensagem(string mensagem)
{
    int valor;
    Console.Write(mensagem);
    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write(mensagem);
    }
    return valor;
}

bool sair = false;
while (!sair)
{
    Console.Clear();

    Console.WriteLine("1 - Ver itens");
    Console.WriteLine("2 - Comprar");
    Console.WriteLine("3 - Repor estoque");
    Console.WriteLine("0 - Sair");

    Console.Write("\nEscolha uma opção do Menu: ");
    string opcao = Console.ReadLine() ?? "";
    switch (opcao)
    {
        case "1":
            VerItens();
            break;
        case "2":
            VerItens();

            try
            {
                int escolha = TryParseComMensagem("\nEscolha qual item você quer comprar: ");

                Item itemEscolhido = EscolherItem(itens, escolha);

                int quantidade = TryParseComMensagem("\nEscolha quantos você quer comprar: ");

                itemEscolhido.Vender(quantidade);
                decimal valorTotal = itemEscolhido.Preco * quantidade;
                Console.WriteLine($"\nParabéns, você comprou {quantidade} {itemEscolhido.Nome} por {valorTotal}");
                Console.Write("\nO estoque foi Atualizado: ");
                Console.WriteLine(itemEscolhido.DescricaoItem());
            }
            catch (MenorOuIgualAZeroException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (LimiteDeEscolhaException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (MaiorQueEstoqueException erro)
            {
                Console.WriteLine(erro.Message);
            }
            break;
        case "3":
            VerItens();

            try
            {
                int escolha = TryParseComMensagem("\nEscolha qual item você quer repor: ");

                Item itemEscolhido = EscolherItem(itens, escolha);

                int quantidade = TryParseComMensagem("\nEscolha quantos você quer adicionar ao estoque: ");

                itemEscolhido.ReporEstoque(quantidade);
                Console.WriteLine($"\nVocê adicionou {quantidade} {itemEscolhido.Nome}");
                Console.Write("\nO estoque foi Atualizado: ");
                Console.WriteLine(itemEscolhido.DescricaoItem());
            }
            catch (MenorOuIgualAZeroException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (LimiteDeEscolhaException erro)
            {
                Console.WriteLine(erro.Message);
            }
            break;
        case "0":
            Console.WriteLine("Compre mais itens na próxima!");
            sair = true;
            break;
        default:
            Console.WriteLine("Digite uma das opções do Menu");
            break;

    }

    if (sair == false)
    {
        //pausa pra ler
        Console.WriteLine("\nAperte enter para continuar");
        Console.ReadLine();
    }
}