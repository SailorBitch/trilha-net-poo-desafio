namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // TODO realizado!!!
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
                      : base(numero, modelo, imei, memoria)
                      {}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // TODO realizado!!!
        public override void InstalarAplicativo(string nomeApp)
        {
        Console.WriteLine("Instalando o aplicativo '" + nomeApp + "' em seu descontinuado Nokia! Por favor, mude de celular!");
        }
    }
}