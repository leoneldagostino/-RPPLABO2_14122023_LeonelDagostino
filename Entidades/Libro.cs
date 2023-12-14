using System.Text;

namespace Entidades
{
    public abstract class Libro
    {
        private bool edicionEspecial;

        protected EClasificacion clasificacion;

        private string nombre;

        public string Detalle
        {
            get
            {
                return AdicionarInformacion();
            }
        }
        public string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }

        protected virtual string AdicionarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Tipo: {this.Tipo}");
            sb.AppendLine($"Clasificacion: {this.clasificacion}");
            if(edicionEspecial)
            {
                sb.AppendLine($"Es edicion especial");
            }
            
            return sb.ToString();
        }
        public abstract void Clasificar();

        protected Libro(string nombre)
        {
            this.nombre = nombre;
        }
        protected Libro(string nombre, bool edicionEspecial) : this(nombre) 
        {
            
        }
        public override string ToString()
        {
            return $"Nombre: {this.nombre} - Tipo: {this.Tipo}";
        }

        public static bool operator ==(Libro libro, Libro otroLibro) 
        {
            if (libro.GetType() == otroLibro.GetType()
                && libro.clasificacion == otroLibro.clasificacion 
                && libro.edicionEspecial == otroLibro.edicionEspecial
                && libro.nombre == otroLibro.nombre)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Libro libro, Libro otroLibro) 
        {
            return !(libro == otroLibro);
        }
    }
    public enum EClasificacion
    {
        Todos,
        Adolescentes,
        Adultos
    }
}