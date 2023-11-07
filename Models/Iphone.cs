namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // TODO realizado!!!
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
                      : base(numero, modelo, imei, memoria)
                        {}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // TODO realizado!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo '" + nomeApp + "' em seu iPhone, seu burguês safado!");
        }
    }
}