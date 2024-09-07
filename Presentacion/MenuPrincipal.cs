using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        PresentacionPerson presentacionPerson = new PresentacionPerson();
        public void Menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 5); Console.Write("MENÚ PRINCIPAL");
                Console.SetCursorPosition(10, 8); Console.Write("1.REGISTRAR PERSONA");
                Console.SetCursorPosition(10, 10); Console.Write("2.ASIGNAR TAREAS");
                Console.SetCursorPosition(10, 12); Console.Write("3.CONSULTAR TAREAS ");
                Console.SetCursorPosition(10, 14); Console.Write("4.ELIMINAR TAREA");
                Console.SetCursorPosition(10, 16); Console.Write("5.ELIMINAR PERSONA");
                Console.SetCursorPosition(10, 18); Console.Write("6. SALIR");
                Console.SetCursorPosition(10, 19); Console.WriteLine("Digite opcion: ");
                Console.SetCursorPosition(26, 19); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        presentacionPerson.AddPerson();
                        break;

                    case 2:
                        Console.Clear();
                        presentacionPerson.AssignTask();
                        break;

                    case 3:
                        Console.Clear();
                        presentacionPerson.ConsultTask();
                        break;

                    case 4:
                        Console.Clear();
                        presentacionPerson.RemoveTask();
                        break;
                    case 5:
                        Console.Clear();
                        presentacionPerson.RemovePerson();
                        break;

                }
            } while (op != 6);
        }
    }
}
