namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            modelo = Modelo;
            imei = Imei;
            memoria = Memoria;

        }

        private string Modelo;
        private string Imei;
        private int Memoria;

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Play Store: Instalando o aplicativo {nomeApp}");
        }

    }
}