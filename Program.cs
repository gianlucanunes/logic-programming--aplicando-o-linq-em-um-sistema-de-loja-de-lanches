// Cria a lista de lanches. São 3 categorias contendo 4 lanches cada, logo, o total de lanches é 12.
List<Lanche> listaLanches = new List<Lanche>() 
{
    new Lanche {NomeCategoria="Normal", NomeLanche="Big Mac", DescLanche="Lanche normal do Mc", PrecoLanche=50.0},
    new Lanche {NomeCategoria="Normal", NomeLanche="Burger King", DescLanche="Lanche normal do BK", PrecoLanche=20.0},
    new Lanche {NomeCategoria="Normal", NomeLanche="Girafas", DescLanche="Lanche normal do Girafas", PrecoLanche=80.0},
    new Lanche {NomeCategoria="Normal", NomeLanche="Habbibs", DescLanche="Lanche normal do habibs", PrecoLanche=25.0},
    new Lanche {NomeCategoria="Vegano", NomeLanche="X-Salada", DescLanche="Lanche vegano com alface", PrecoLanche=30.0},
    new Lanche {NomeCategoria="Vegano", NomeLanche="X-Ovo", DescLanche="Lanche vegano com ovo", PrecoLanche=45.0},
    new Lanche {NomeCategoria="Vegano", NomeLanche="X-Tomate", DescLanche="Lanche vegano com tomate", PrecoLanche=32.0},
    new Lanche {NomeCategoria="Vegano", NomeLanche="X-Salada dupla", DescLanche="Lanche vegano com dupla alface", PrecoLanche=33.0},
    new Lanche {NomeCategoria="Junk", NomeLanche="Mc Lanche feliz", DescLanche="Lanche para as crianças", PrecoLanche=44.0},
    new Lanche {NomeCategoria="Junk", NomeLanche="Mc Flurry", DescLanche="Lanche com sorvete", PrecoLanche=50.0},
    new Lanche {NomeCategoria="Junk", NomeLanche="Burger Mat", DescLanche="Hamburguer da casa", PrecoLanche=25.0},
    new Lanche {NomeCategoria="Junk", NomeLanche="Cheese Duplo", DescLanche="Hamburguer com queijo extra", PrecoLanche=22.0},
};

System.Console.WriteLine("\nBem vindo. Lista de lanches abaixo.\n");


// Lista os lanches na tela, junto da categoria e do preço em R$.
foreach (var item in listaLanches) 
{
    System.Console.WriteLine($"Categoria: {item.NomeCategoria} --- Lanche: {item.NomeLanche} --- Preço: {item.PrecoLanche:c}");
}


// Pergunta ao usuário qual filtro de categoria ele vai aplicar: normal, vegano ou junk.
_etq0:
System.Console.WriteLine("\nDeseja aplicar qual filtro de categoria?\n(N) Normal\n(V) Vegano\n(J) Junk");
string opcFiltro = Console.ReadLine().ToUpper();


// Cria as variáveis de filtro.
string filtroCategoria;
string filtroLanche;


// Valida a opção escolhida pelo usuário.
if (opcFiltro != "N" && opcFiltro != "V" && opcFiltro != "J") 
{
    System.Console.WriteLine("\nOpção inválida! Tente novamente!\n");
    goto _etq0;
}


// Lista os lanches da categoria normal junto com o preço em R$.
else if (opcFiltro == "N") 
{
    System.Console.WriteLine("\nNa lista abaixo, temos os lanches da categoria Normal.\n");
    filtroCategoria = "Normal";

    // Cria a Query com o filtro aplicado.
    var catQuery = listaLanches.Where(i => i.NomeCategoria == filtroCategoria);

    foreach (Lanche item in catQuery) 
    {
        System.Console.WriteLine($"Lanche: {item.NomeLanche} --- Preço: {item.PrecoLanche:c}");
    }
}


// Lista os lanches da categoria vegano junto com o preço em R$.
else if (opcFiltro == "V")
{
    System.Console.WriteLine("\nNa lista abaixo, temos os lanches da categoria Vegano.\n");
    filtroCategoria = "Vegano";

    // Cria a Query com o filtro aplicado.
    var catQuery = listaLanches.Where(i => i.NomeCategoria == filtroCategoria);

    foreach (Lanche item in catQuery) 
    {
        System.Console.WriteLine($"Lanche: {item.NomeLanche} --- Preço: {item.PrecoLanche:c}");
    }
}


// Lista os lanches da categoria junk junto com o preço em R$.
else if (opcFiltro == "J")
{
    System.Console.WriteLine("\nNa lista abaixo, temos os lanches da categoria Junk.\n");
    filtroCategoria = "Junk";

    // Cria a Query com o filtro aplicado.
    var catQuery = listaLanches.Where(i => i.NomeCategoria == filtroCategoria);

    foreach (Lanche item in catQuery) 
    {
        System.Console.WriteLine($"Lanche: {item.NomeLanche} --- Preço: {item.PrecoLanche:c}");
    }
}


// Pede ao usuário para que este digite o nome de um lanche para ver os detalhes.
_etq1:
System.Console.WriteLine("\nPor favor, escreva o nome de um lanche na tela para exibir mais detalhes sobre o mesmo.");
filtroLanche = Console.ReadLine().ToLowerInvariant();

// Cria a Query com o filtro de nome do lanche aplicado.
var LanQuery = listaLanches.Where(i => i.NomeLanche == filtroLanche);


// Verifica se a Query está vazia, isto é, se o lanche digitado existe.
if (LanQuery.Count() == 0) 
{
    System.Console.WriteLine("\nO lanche digitado não existe. Por favor, tente novamente.");
    goto _etq1;
}


// Caso o lanche digitado exista, imprime os detalhes do lanche na tela.
foreach (Lanche item in LanQuery) 
{
    System.Console.WriteLine($"\nNome do lanche: {item.NomeLanche}\nCategoria do lanche: {item.NomeCategoria}\nDescrição do lanche: {item.DescLanche}\nPreço do lanche: {item.PrecoLanche:c}\nData de fabricação: {item.DtFabricacao:dd/MM/yyyy}");
}

System.Console.WriteLine("\nTecle espaço para encerrar...");
Console.ReadKey();

