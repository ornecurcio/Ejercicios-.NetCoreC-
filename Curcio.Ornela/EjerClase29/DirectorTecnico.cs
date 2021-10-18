using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase29
{
    class DirectorTecnico:Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        { }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento; 
        }
        #region Propiedades
        public DateTime FechaNacimiento 
        {
            get 
            {
                return this.fechaNacimiento;    
            }
            set 
            {
                if (value.Year >= 1850)
                {
                    this.fechaNacimiento = value; 
                }
            }
        }
        #endregion
        public new string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.MostrarDatos());
            stringBuilder.AppendLine($"Fecha Nacimiento: {FechaNacimiento}"); 
            return stringBuilder.ToString(); 
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if (((object)dt1) == null && ((object)dt2) == null)
            {
                return true;
            }
            else
            {
                if (((object)dt1) != null && ((object)dt2) != null 
                    && dt1.Nombre == dt2.Nombre && dt1.FechaNacimiento==dt2.FechaNacimiento)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2); 
        }
    }
}
