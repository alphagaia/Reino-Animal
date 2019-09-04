using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Ave : Animal
    {

        public void Migra()
        {

        }

        override
        public void Locomove()
        {
            Console.WriteLine("Voou a uma velocidade de " + Velocidade + "KM/h");
        }
    }
}
