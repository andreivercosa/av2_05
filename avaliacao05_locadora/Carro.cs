using System;
namespace avaliacao05_locadora
{
    public class Carro : Veiculo
    {
        public Carro(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }
        public override void descricao()
        {
            Console.WriteLine("Carro: ");
        }
        public Carro()
        {
        }
    }
}
