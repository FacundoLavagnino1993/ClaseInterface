using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Pez:Animal
    {
        private string _nombre;

        public Pez(string nombre)
        {
            this._nombre = nombre;
        }

        public override void Comer()
        {
            Console.WriteLine("Este animal come placton");
        }


    }
}
