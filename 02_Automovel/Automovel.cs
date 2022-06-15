using System.Globalization;

namespace _02_Automovel
{
    internal class Automovel
    {
        public string placa;
        public string modelo;
        public string cor;
        public int ano;
        public decimal valor;
        public byte combustivel;
        public const byte GASOLINA = 1; 
        public const byte ALCOOL = 2;
        public const byte DIESEL = 3;
        public const byte GAS = 4;

        public Automovel(string placa, string modelo, byte combustivel, string cor, int ano)
        {
            if (combustivel != GASOLINA && combustivel != ALCOOL && combustivel != DIESEL && combustivel != GAS)
            {
                throw new ArgumentException("Tipo de combustivel inválido!");
            }
            this.combustivel = combustivel;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
        }

        public virtual void CalculaValor()
        {
            switch (combustivel)
            {
                case GASOLINA:
                    valor = 12000;
                    break;
                case ALCOOL:
                    valor = 10500;
                    break;
                case DIESEL:
                    valor = 11000;
                    break;
                case GAS:
                    valor = 13000;
                    break;
                default: throw new ArgumentException("Tipo de combustivel inválido!");
            }
        }
        private string NomeCombustivel(byte combustivel)
        {
            switch (combustivel)
            {
                case GASOLINA:
                    return "Gasolina";
                    break;
                case ALCOOL:
                    return "Álcool";
                    break;
                case DIESEL:
                    return "Díesel";
                    break;
                case GAS:
                    return "Gás";
                    break;
            }
            return "";
        }
        public virtual void Imprimir()
        {
            Console.WriteLine($"----------------------\n" +
                              $"Modelo: {modelo}\n" +
                              $"Cor: {cor}\n" +
                              $"Ano: {ano}\n" +
                              $"Placa: {placa}\n" +
                              $"Combustivel: {NomeCombustivel(combustivel)}\n" +
                              $"Valor: {valor.ToString("C2", CultureInfo.CurrentCulture)}\n");            
        }
    }
}