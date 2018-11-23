using System;

namespace avaliacao05_locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Console.WriteLine("Informe a marca: ");
            carro.marca = Console.ReadLine();

            Console.WriteLine("Informe a modelo: ");
            carro.modelo = Console.ReadLine();

            Console.WriteLine("Informe a Qtd Portas: ");
            carro.cor = Console.ReadLine();

            carro.descricao();

            Console.WriteLine("Marca: {0}\nModelo: {1}\nQtd Portas: {2}", carro.marca, carro.modelo, carro.cor);
        }
    }
}
