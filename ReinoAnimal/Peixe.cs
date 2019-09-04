using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Peixe : Animal
    {
        override
        public void Locomove()
        {
            Console.WriteLine("Nadou a uma velocidade de " + Velocidade + "KM/h");
        }
    }
}
