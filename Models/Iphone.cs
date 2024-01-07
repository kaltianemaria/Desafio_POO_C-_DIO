namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
        }

        public override string ToString()
        {
            return $"Iphone - Modelo: {this.Modelo}, Número: {this.Numero}, IMEI: {this.Imei}, Memória: {this.Memoria}GB";
        }
    }
}