using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

using Entity;

namespace BLL
{
    public class PersonaService
    {
        PersonaRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
        public void Guardar(Persona persona)
        {
            personaRepository.Guardar(persona);
        }
        public List<Persona> Consultar()
        {
            return personaRepository.Consultar();
        }
    }
}
