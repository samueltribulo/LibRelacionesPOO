using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPOO
{
    public class Alumno
    {
        public Alumno(string Nombre) {
        
            this.Nombre = Nombre;

        }
        public string Nombre {
            get
            {
                return Nombre;
            }
            set
            {
                if (Nombre.Trim().Length < 1)
                {
                    throw new ArgumentException("Debe ingresar un nombre.");
                }
                else if (Nombre.Trim().Length > 50)
                {

                    throw new ArgumentException("El nombre debe tener entre 1 y 50 caracteres.");

                }
            }
        }
        public Docente Docente { get; set; }

    }
}
