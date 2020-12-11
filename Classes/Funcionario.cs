using System;

namespace POO_Polimosrfismo_Sobrecarga.Classes
{
    public class Funcionario
    {
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        
        }

        public string Name { get; set; }

        //Atividade

        public string[] lista = { "Paulo", "Tsuka", "Priscila", "Fernanda" };
        
        public void Mostrar()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice)
        {
            Console.WriteLine("Item " + indice + " da lista é: " + lista[indice]);
        }

        public void Mostrar(string busca)
        {
            foreach (var item in lista)
            {
                if (item == busca)
                {
                    Console.WriteLine("Resultado da busca: " + item);
                }
            }
        }
        
        
    }
}
    