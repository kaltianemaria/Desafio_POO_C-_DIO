namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        protected string Numero;
        protected string Modelo;
        protected string Imei;
        protected int Memoria;


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string GetNumero()
        {
            return Numero;
        }

        public void setNumero(string numero)
        {
            Numero = numero;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public string GetImei()
        {
            return Imei;
        }

        public void SetImei(string imei)
        {
            Imei = imei;
        }

        public int GetMemoria()
        {
            return Memoria;
        }

        public void SetMemoria(int memoria)
        {
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}