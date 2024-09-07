using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class PresentacionPerson
    {
        private BLL.PersonService PersonService;

        public void AddPerson()
        {
            Console.Clear();
            Person person = new Person();
            Console.SetCursorPosition(25, 5); Console.WriteLine("MENÚ PARA PERSONA");
            Console.SetCursorPosition(10, 8); Console.WriteLine("INGRESE IDENTIFICACIÓN: ");
            Console.SetCursorPosition(39, 8); person.Id = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10, 10); Console.WriteLine("INGRESE EL NOMBRE: ");
            Console.SetCursorPosition(39, 10); person.Name = Console.ReadLine();
            Console.SetCursorPosition(10, 12); Console.WriteLine("INGRESE CORREO ELECTRONICO: ");
            Console.SetCursorPosition(39, 12); person.Email=Console.ReadLine();

            Console.ReadKey();
        }
        public void AssignTask()
        {

        }
        public void ConsultTask()
        {

        }
        public void RemoveTask()
        {

        }
        public void RemovePerson()
        {

        }
    }
}
