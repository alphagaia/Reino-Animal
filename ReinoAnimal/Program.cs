using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instancie um pato, um tubarão, um peixe, um cachorro e um humano. Para o objeto instanciado a partir da classe ​Humano​, chame todos os métodos disponíveis (desde os que foram declarados na classe ​Animal​ até a classe final). 

            var pato = new Pato();
            var tubarao = new Tubarao();
            var peixe = new Peixe();
            var humano = new Humano(70,"sons de humanos",10,70,"00000000000");

            humano.Nasce();
            humano.Sorrir();
            humano.Locomove();

            var filho = humano.Reproduz();

            humano.Morre();

            Console.ReadKey();
        }
    }
}
