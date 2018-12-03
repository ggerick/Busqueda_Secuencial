using System;

namespace Busqueda_secuencial
{
    class Busqueda
    {
        int[] enteros = {  2,3,5,7,11,13,17,19,23,27,29 };
        int posicion = 0;
        string[] RealEngineering = { "Sistemas", "Mecatronica", "Biomedica", "Robotica", "Bioquimica", "Quimica", "Aeronautica", "Electromecanica"};
        bool answer = false;

        public void Encontrar()
        {
            Console.WriteLine("Que ingenieria deseas conocer");
            string nombre = Console.ReadLine();

            for (int i = 0; i < RealEngineering.Length; i++)
            {
                //Console.WriteLine("Que ingenieria deseas conocer");
                //string nombre = Console.ReadLine();
                if (RealEngineering[i] == nombre)
                {
                    answer = true;
                    posicion = i;
                }
               
            }
            if (answer)
            {
                Console.WriteLine("Ingenieria {0} encontrada en la lista en la posicion {1}", nombre,posicion);
            }
            else
                Console.WriteLine("{0} no es una ingenieria de verdad", nombre);


            Console.ReadKey();
            Console.Clear();
            answer = false;
            int pos = 0;

            Console.WriteLine("Inserta un numero primo del 1 al 30");
            int numero = int.Parse(Console.ReadLine());
            for (int j = 0; j < enteros.Length; j++)
            {
                if (enteros[j] == numero)
                {
                    answer = true;
                    pos = j;
                }

            }
            if (answer)
            {
                Console.WriteLine("Numero primo encontrado en la posicion {0} del arreglo ", pos);
            }
            else
                Console.WriteLine("{0} no es un numero primo", numero);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Busqueda secuencial = new Busqueda();
            secuencial.Encontrar();

        }
    }
}
