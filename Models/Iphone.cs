using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo \"{nomeApp}\" no iPhone");
            Thread.Sleep(1500);
            Console.WriteLine($"O aplicativo \"{nomeApp}\" foi instalado no iPhone");
        }
        
        public override void DesinstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Desinstalando aplicativo \"{nomeApp}\" no iPhone");
            Thread.Sleep(1000);
            Console.WriteLine($"O aplicativo \"{nomeApp}\" foi desinstalado no iPhone\n");
        }
    }
}