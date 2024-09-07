using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PersonService : ICrud
    {
        List <Person> personas;
        //public PersonService()
        //{
        //    personas = new List<PersonService>();
        //}
        public string Add(Person entity)
        {
            try
            {
                // validaciones
                personas.Add(entity);
                return $"se agrego la persona {entity.Name}";
            }
            catch (Exception)
            {
                return "no se agrego la persona";
            }

        }

        public string Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return personas;
        }

        public string Upgrade(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
