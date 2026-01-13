using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void DeletarAplicativo(string nomeApp)
        {
            if (aplicativos.Any())
            {
                Console.WriteLine($"O aplicativo \"{nomeApp}\" foi deletado no Nokia");
                aplicativos.Remove(nomeApp);
            }
            else
            {
                Console.WriteLine($"O aplicativo \"{nomeApp}\" não está instalado no Nokia");               
            }
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (aplicativos.Any())
            {
                Console.WriteLine($"O aplicativo \"{nomeApp}\" já está instalado no Nokia");
            }
            else
            {
                Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
                aplicativos.Add(nomeApp);
            }                
        }
    }
}