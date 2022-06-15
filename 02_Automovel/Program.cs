using _02_Automovel;

byte combustivel;
string arCondicionado;
string vidroEletrico;
string direcaoHidraulica;
string placa;
string modelo;
string cor;
int ano;
try
{
    Console.Write("Placa: ");
    placa = Console.ReadLine();
    Console.Write("Modelo: ");
    modelo = Console.ReadLine();
    Console.Write("Cor: ");
    cor = Console.ReadLine();
    Console.Write("Ano: ");
    int.TryParse(Console.ReadLine(), out ano);

    Console.Write("Escolha um tipo de combustível:\n" +
                      "(1) Gasolina\n" +
                      "(2) Alcool\n" +
                      "(3) Diesel\n" +
                      "(4) Gas\n" +
                      "Opção: ");
    byte.TryParse(Console.ReadLine(), out combustivel);


    Console.WriteLine("Gostaria de algum adicional de luxo?");
    Console.Write("Ar Condicionado (S/N): ");
    arCondicionado = Console.ReadLine().ToUpper();
    Console.Write("Direção Direção Hidráulica (S/N): ");
    direcaoHidraulica = Console.ReadLine().ToUpper();
    Console.Write("Vidro Elétrico (S/N): ");
    vidroEletrico = Console.ReadLine().ToUpper();

    Automovel automovel;

    if (arCondicionado == "S" || vidroEletrico == "S" || direcaoHidraulica == "S")
    {
        automovel = new AutomovelLuxo(placa, modelo, combustivel, cor, ano, direcaoHidraulica, arCondicionado, vidroEletrico);
    }
    else
    {
        automovel = new Automovel(placa, modelo, combustivel, cor, ano);
    }
    automovel.CalculaValor();
    automovel.Imprimir();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}