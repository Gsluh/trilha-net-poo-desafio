namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            numero = Numero;
            modelo = Modelo;
            imei = Imei;
            memoria = Memoria;

        }

        private string Modelo;
        private string Imei;
        private int Memoria;

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"AppStore: Instalando o aplicativo {nomeApp}");
        }

    }
}