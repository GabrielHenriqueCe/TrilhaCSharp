using ClasseListaMetodo.Rep4.Missoes;
using ClasseListaMetodo.Rep4.Missoes.Exceptions;
using System.Linq.Expressions;

Heroi heroi = new Heroi("Arin");

var missoes = new List<Missao>
{
    new Missao ("Caçar slimes", 1, 60),
    new Missao ("Escoltar o mercador", 1, 50),
    new Missao ("Limpar a caverna", 2, 80),
    new Missao ("Enfrentar o golem", 3, 150),
};

void ListarMissoes(List<Missao> missoes)
{
    for (int i = 0; i < missoes.Count; i++)
    {
        Console.WriteLine($"{i + 1} - " + missoes[i].FichaDaMissao());
        Console.WriteLine();
    }
}

bool sair = false;
while (!sair)
{
    Console.Clear();
    Console.WriteLine("1 - Ver Heroi");
    Console.WriteLine("2 - Ver Missões");
    Console.WriteLine("3 - Fazer Missão");
    Console.WriteLine("0 - Sair");

    Console.Write("\nEscolha uma opção do Menu: ");
    string opcao = Console.ReadLine() ?? "";

    switch (opcao)
    {
        case "1":
            Console.WriteLine(heroi.FichaDoHeroi());
            break;
        case "2":
            ListarMissoes(missoes);
            break;
        case "3":
            ListarMissoes(missoes);

            try
            {
                Console.Write("\nEscolha uma missão para concluir: ");
                int nivelAntes = heroi.Nivel;
                int escolha;
                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.WriteLine("Digite um número.");
                    break;
                }
                if (escolha < 1 || escolha > missoes.Count)
                {
                    throw new RangeDaEscolhaException(missoes);
                }
                heroi.FazerMissao(missoes[escolha - 1]);

                Console.Write($"\n{heroi.Nome} ganhou {missoes[escolha - 1].XpRecompensa} de XP. ");
                if (nivelAntes < heroi.Nivel)
                {
                    Console.Write($"Subiu para o Nível {heroi.Nivel}!");
                }
                Console.WriteLine();
                Console.WriteLine(heroi.FichaDoHeroi());
            }
            catch (MenorOuIgualAZeroException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (MenorQueZeroException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (NivelAbaixoDoNecessarioException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (MissaoJaConcluidaException erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (RangeDaEscolhaException erro)
            {
                Console.WriteLine(erro.Message);
            }
            break;
        case "0":
            Console.WriteLine("Volte para fazer mais missões na próxima!");
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