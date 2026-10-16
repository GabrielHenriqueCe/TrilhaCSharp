using ClasseListaMetodo.Rep2.PetFome;

var pets = new List<Pet>();

void Cadastrar()
{
    Console.Write("Escolha um nome para o pet: ");
    string nome = Console.ReadLine() ?? "";

    var pet = new Pet(nome);
    pets.Add(pet);

    Console.WriteLine($"Nome:{pet.Nome} foi cadastrado");
}

void Listar()
{
    if (pets.Count == 0)
    {
        Console.WriteLine("Nenhum pet cadastrado");
        return;
    }

    for (int i = 0; i <  pets.Count; i++)
    {
        Console.WriteLine($"{i+1} - " + pets[i].FichaDoPet());
    }
}

bool sair = false;

while (!sair)
{
    Console.Clear();
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Passar Turno");
    Console.WriteLine("4 - Alimentar");
    Console.WriteLine("0 - Sair");

    Console.Write("\nEscolha uma opção do Menu: ");
    string opcao = Console.ReadLine() ?? "";

    switch (opcao)
    {
        case "1":
            Cadastrar();
            break;
        case "2":
            Listar();
            break;
        case "3":
            foreach (var pet in pets)
            {
                pet.PassarTurno();
            }
            Console.WriteLine("A fome de todos os pets diminuiu em 10");
            break;
        case "4":

            if (pets.Count == 0)
            {
                Console.WriteLine("Nenhum pet cadastrado!");
                break;
            }

            Listar();

            int escolha;
            Console.Write("Escolha um pet para Alimentar: ");
            while (!int.TryParse(Console.ReadLine(), out escolha))
            {
                Console.Write("Escolha um pet para Alimentar: ");
            }

            if (escolha <= 0 || escolha > pets.Count)
            {
                Console.WriteLine("Valor invalido");
                break;
            }

            pets[escolha - 1].Alimentar();
            Console.WriteLine(pets[escolha - 1].FichaDoPet());

            break;
        case "0":
            Console.WriteLine("Adote mais pets para alimentar na próxima!");
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