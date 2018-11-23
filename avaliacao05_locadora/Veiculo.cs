using System;
namespace avaliacao05_locadora
{
    public abstract class Veiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }

        public virtual void descricao(){
            Console.WriteLine("Qualquer veiculo");
        }
        public Veiculo()
        {
        }
    }
}
