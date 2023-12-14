using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeMisterio : Libro
    {
        public override void Clasificar()
        {
            Random random = new Random();
            if ( random.Next(1,6) < 3)
            {
                clasificacion = EClasificacion.Adolescentes;
            }
            else
            {
                clasificacion = EClasificacion.Adultos;
            }
        }

        public LibroDeMisterio(string nombre, bool edicionEspecial) : base (nombre, edicionEspecial)
        {
            
        }
    }
}
