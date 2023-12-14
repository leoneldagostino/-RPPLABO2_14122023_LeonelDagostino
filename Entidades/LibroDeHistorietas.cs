using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroDeHistorietas : Libro
    {
        private bool ilustracionesColoridas;

        protected override string AdicionarInformacion()
        {
            string informacion = base.AdicionarInformacion();
            string informacionCompleta;
            if (ilustracionesColoridas)
            {
                informacionCompleta = string.Format("{0} - Edicion Rayo Cromatico", informacion);
            }
            else
            {
                informacionCompleta = string.Format("{0} - Edicion Maestro MonoCromo", informacion);
            }


            return informacionCompleta;
        }

        public override void Clasificar()
        {
            clasificacion = EClasificacion.Todos;
        }

        public LibroDeHistorietas(string nombre, bool ilustracionesColoridas) : base(nombre,true)
        {
            this.ilustracionesColoridas = ilustracionesColoridas;
            
        }
    }
}
