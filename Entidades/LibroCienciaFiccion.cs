using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroCienciaFiccion : Libro
    {
        private ENivelDificultad nivelDificultad;

        public LibroCienciaFiccion(string nombre, ENivelDificultad nivelDificultad) : base(nombre)
        {
            this.nivelDificultad = nivelDificultad;
        }

        public override void Clasificar()
        {
            if (this.nivelDificultad == ENivelDificultad.Baja)
            {
                this.clasificacion = EClasificacion.Todos;
            }
            else if (this.nivelDificultad == ENivelDificultad.Media)
            {
                this.clasificacion = EClasificacion.Adolescentes;
            }
            else if (this.nivelDificultad == ENivelDificultad.Alta)
            {
                this.clasificacion = EClasificacion.Adultos;
            }
        }
        protected override string AdicionarInformacion()
        {
            string informacion = base.AdicionarInformacion();
            string informacionCompleta = string.Format("{0} - Nivel de Dificultad: {1}",informacion,this.nivelDificultad);

            return informacionCompleta;
        }
    }

    public enum ENivelDificultad
    {
        Baja,
        Media,
        Alta
    }
}
