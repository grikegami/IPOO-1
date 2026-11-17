using Ex1;

Carro CadastrarCarro()
{
    Console.WriteLine("Vamos inserir os carros... \n\n");

    Console.WriteLine("Digite o Fabricante do seu carro.");
    string fab = Console.ReadLine();
    Console.WriteLine("Digite o Modelo do seu carro.");
    string mod = Console.ReadLine();
    Console.WriteLine("Digite o ano de fabricação do seu carro.");
    int anoFab = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano do modelo do seu carro.");
    int anoMod = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de venda do seu carro.");
    double valorVenda = double.Parse(Console.ReadLine());


    Carro c = new();

    c.setFabricante(fab);
    c.setModelo(mod);
    c.setAnoFabricacao(anoFab);
    c.setAnoModelo(anoMod);
    c.setValorVenda(valorVenda);

    return c;
}

Carro[] carros = new Carro[4];

for (int i =0;  i < carros.Length; i++)
{
    var carro = CadastrarCarro();
    carros[i] = carro;

}

void MostrarCarros()
{

    for (int i = 0; i < carros.Length; i++)
    {
        Console.WriteLine(carros[i].ToString());
    }
}

MostrarCarros();
Console.ReadKey();