using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }

        public decimal Pulsaciones()
        {
            if (Sexo.Equals("F"))
            {
                return (220 - Edad) / 10;
            }
            else if (Sexo.Equals("M"))
            {
                return (210 - Edad) / 10;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"\nIdentificacion: {Identificacion} \nNombre: {Nombre}  \nEdad: {Edad} \nSexo: {Sexo} \nPulsaciones: {Pulsaciones()}\n";
        }
    }
}
