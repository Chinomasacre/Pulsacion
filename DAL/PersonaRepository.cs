using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;

namespace DAL
{
    public class PersonaRepository
    {
        List<Persona> Personas;
        string ruta = "Persona.txt";
        public PersonaRepository()
        {

        }
        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{persona.Identificacion}+{persona.Nombre}+{persona.Edad}+{persona.Sexo}+{persona.Pulsaciones()}");
            escritor.Close();
            file.Close();
        }
        public List<Persona> Consultar()
        {
            Personas = new List<Persona>();
            
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            string Linea = string.Empty;
            while((Linea = streamReader.ReadLine()) != null)
            {
                char delimiter = '+';
                string[] DatosPersona = Linea.Split(delimiter);

                Persona persona = new Persona();
                persona = Mapear(persona);
                Personas.Add(persona);
            }
            streamReader.Close();
            fileStream.Close();

            return Personas;
        }
        public Persona Mapear(Persona persona)
        {
            persona.Identificacion = DatosPersona[0];
            persona.Nombre = DatosPersona[1];
            persona.Edad = Convert.ToInt32(DatosPersona[2]);
            persona.Sexo = DatosPersona[3];
            return persona;
        }

    }
}
