using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entity;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>(); 
            PersonaService personaService = new PersonaService();
            Persona persona = new Persona();

            Console.WriteLine("Digite Identificacion: ");
            persona.Identificacion = Console.ReadLine();
            Console.WriteLine("Digite Nombre: ");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Digite Edad: ");
            persona.Edad = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Digite Sexo: ");
            persona.Sexo = Console.ReadLine();

            //Console.WriteLine(persona.ToString());

            personaService.Guardar(persona);

            personas = personaService.Consultar();

            foreach(Persona persona2 in personas)
            {
                Console.WriteLine( persona2.ToString());
            }

            Console.ReadKey();
        }
    }
}
