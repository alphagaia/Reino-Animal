using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Mamifero : Animal
    {
        public void Amamenta()
        {

        }

        //PS: Baleia e morcegos são mamíferos
        override
        public void Locomove()
        {
            Console.WriteLine(this.GetType().Name + " andou a uma velocidade de " + Velocidade + "KM/h");

        }

    }
}
