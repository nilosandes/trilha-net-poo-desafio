namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo \"{nomeApp}\" no Nokia");
            Thread.Sleep(2500);
            Console.WriteLine($"O aplicativo \"{nomeApp}\" foi instalado no Nokia");
        }
       
        public override void DesinstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Desinstalando aplicativo \"{nomeApp}\" no Nokia");
            Thread.Sleep(2000);
            Console.WriteLine($"O aplicativo \"{nomeApp}\" foi desinstalado no Nokia\n");
        }
    }
}