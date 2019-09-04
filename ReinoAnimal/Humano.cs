using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Humano : Mamifero
    {
        protected string CPF { get; set; }

        public Humano(int idade, string som, float velocidade, float peso, string cpf)
        {
            Idade = idade;
            Som = som;
            Velocidade = velocidade;
            Peso = peso; 
            CPF = cpf;
        }

        public void Sorrir()
        {

        }
    }
}
