using System.Globalization;

namespace _02_Automovel
{
    internal class AutomovelLuxo : Automovel
    {
        private string direcaoHidraulica;
        private string arCondicionado;
        private string vidroEletrico;
        private decimal valorOpcionais = 0;
        private const string acessorioPadrao = "Computador de Bordo";

        public AutomovelLuxo(string placa, string modelo, byte combustivel, string cor, int ano, 
        string direcaoHidraulica, string arCondicionado, string vidroEletrico) : base(placa, modelo, combustivel, cor, ano)
        {
            this.direcaoHidraulica = direcaoHidraulica;
            this.arCondicionado = arCondicionado;
            this.vidroEletrico = vidroEletrico;
        }

        public override void CalculaValor()
        {
            base.CalculaValor();
            if (arCondicionado == "S")
            {
                valorOpcionais += 2000;
            }
            if (direcaoHidraulica == "S")
            {
                valorOpcionais += 1500;
            }
            if (vidroEletrico == "S")
            {
                valorOpcionais += 800;
            }
        }
        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("----------------------");
            Console.WriteLine("Adicionais Luxo");
            Console.WriteLine(acessorioPadrao);
            if (arCondicionado == "S")
            {
                Console.WriteLine("Ar Condicionado: R$ 2.000,00");
            }
            if (direcaoHidraulica == "S")
            {
                Console.WriteLine("Direção Hidráulica: R$ 1.500,00");
            }
            if (vidroEletrico == "S")
            {
                Console.WriteLine("Vidro Elétrico: R$ 800,00");
            }
            Console.WriteLine($"Valor: {(valor + valorOpcionais).ToString("C2", CultureInfo.CurrentCulture)}");

        }
    }
}
