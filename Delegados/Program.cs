using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        delegate int Suma(int numero1, int numero2);

        private static int Hacer_suma(int n1, int n2)
        {
            return n1 + n2;
        }

        static void Main(string[] args)
        {
            //Delegado apuntando a una función
            Suma d_suma = Hacer_suma;
            Console.WriteLine(d_suma(1, 2).ToString());

            //Delegado creado dinamicamente
            Suma d_suma2 = (x, y) => x + y;
            Console.WriteLine(d_suma2(5, 5));

            //Creando explicitamente el delegado
            Suma d_suma3 = new Suma(Hacer_suma);
            Console.WriteLine(d_suma3(8, 8));

            //Mandar delegado por parametro
            Suma d_suma4 = new Suma(Hacer_suma);
            Hacer_algo(Hacer_suma);

            Console.ReadLine();

        }

        private static void Hacer_algo(Suma s_delegate)
        {
           Console.WriteLine(  s_delegate(5, 3));
        }
    }
}
