using ClasseListaMetodo.Rep1.Pets;

var pets = new List<Pet> ();

void CadastrarPet(List<Pet> pets)
{
    Console.Write("Nome do pet: ");
    string nome = Console.ReadLine() ?? "";

    //se nascer de um ovo a espécie é aleatória entre algumas cadastradas, se for escolhida ele ja vem com a espécie, aqui estamos apenas simulando
    string especie = "Cachorro";
    Console.WriteLine($"A espécie do pet escolhida é: {especie}");

    int nivel = 1;
    Console.WriteLine($"O Pet nasce Nivel {nivel}");

    var pet = new Pet(nome, especie, nivel);
    pets.Add(pet);
}

void ListarPets(List<Pet> pets)
{
    foreach (var pet in pets)
    {
        Console.WriteLine(pet.FichaDoPet());
    }
}

bool sair = false;

while(!sair)
{
    Console.Clear();
    Console.WriteLine("1 - Cadastrar Pet");
    Console.WriteLine("2 - Listar Pets");
    Console.WriteLine("0 - Sair");

    Console.Write("\nEscolha uma opção do Menu: ");
    string opcao = Console.ReadLine() ?? "";
    switch (opcao)
    {
        case "1":
            CadastrarPet(pets);
            break;
        case "2":
            ListarPets(pets);
            break;
        case "0":
            Console.WriteLine("Escolha mais pets na próxima!");
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
