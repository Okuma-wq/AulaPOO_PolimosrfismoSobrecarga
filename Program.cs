using System;
using POO_Polimosrfismo_Sobrecarga.Classes;

namespace POO_Polimosrfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            f.Mostrar();
            f.Mostrar("Priscila");
            f.Mostrar(3);
        }
    }
}
