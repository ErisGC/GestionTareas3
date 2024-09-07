using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new ENTITY.Person(1, "Pedro", "pedro@a.com");
            var person2 = new ENTITY.Person(2, "Ana", "ana@b.com");
            var person3 = new ENTITY.Person(3, "Luis", "luis@c.com");
            var person4 = new ENTITY.Person(4, "Maria", "maria@d.com");
            var person5 = new ENTITY.Person(5, "Carlos", "carlos@e.com");
            var person6 = new ENTITY.Person(6, "Laura", "laura@f.com");
            var person7 = new ENTITY.Person(7, "Javier", "javier@g.com");
            var person8 = new ENTITY.Person(8, "Isabel", "isabel@h.com");
            var person9 = new ENTITY.Person(9, "Marta", "marta@i.com");
            var person10 = new ENTITY.Person(10, "Ricardo", "ricardo@j.com");

            DAL.PersonRepository personRepository = new DAL.PersonRepository();
            Console.WriteLine(personRepository.Save(person6));
            Console.WriteLine(personRepository.Save(person7));
            Console.WriteLine(personRepository.Save(person8));
            var lista = personRepository.Read();
            Console.WriteLine("Nombres");
            foreach (var item in lista) 
            {
                Console.WriteLine(item.Name);
                Console.WriteLine( "-------------");

            }

            Console.ReadKey();


        }
    }
}
