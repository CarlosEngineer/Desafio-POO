namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"'IPhone Warning' - O seu aplicativo {nomeApp} foi instalado com sucesso!");
        }
    }
}