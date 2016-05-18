using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    class Gato:Animal
    {
        protected string _nombre;

        public Gato(string nombre)
        {
            this._nombre = nombre;
        }

        public override void Comer()
        {
            Console.WriteLine("Este animal come peces");
        }
    }
}
