namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void DeletarAplicativo(string nomeApp)
        {
            if (aplicativos.Any())
            {
                Console.WriteLine($"O aplicativo \"{nomeApp}\" foi deletado no Iphone");
                aplicativos.Remove(nomeApp);
            }
            else
            {
                Console.WriteLine($"O aplicativo \"{nomeApp}\" não está instalado no Iphone");
            }
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (aplicativos.Any())
            {
                Console.WriteLine($"O aplicativo \"{nomeApp}\" já está instalado no Iphone");
            }
            else
            {
                Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone");
                aplicativos.Add(nomeApp);
            }
        }
    }
}