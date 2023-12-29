namespace DesafioPOO.Models
{
    //Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string modelo, string imei, int memoria) : base(modelo, imei, memoria){

        }
        //Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}... ");
        }
    }
}