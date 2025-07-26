namespace Workspace.Models
{
    public abstract class Smartphone
    {
        // Construtores
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        } 
        // Atributos declarados
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        
        // Métodos declarados
        public void Ligar()
        {
            Console.WriteLine("Ligando");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
