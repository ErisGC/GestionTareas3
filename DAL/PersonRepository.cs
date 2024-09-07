using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ENTITY;



namespace DAL
{
    public class PersonRepository
    {
        string fileName = "person.txt";
        public PersonRepository() { }

        public string Save( Person person)
        {
            try
            {
                //1. abrrir
                StreamWriter writer = new StreamWriter(fileName, true);
                //2 operaciones
                writer.WriteLine(person.ToString());  
                //3 cerrar
                writer.Close();
                return $"se ha agregado la persona {person.Name}";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public List<Person> Read()
        {
            try
            {
                string line;
                List<Person> personList = new List<Person>();
                //1. abrrir
                StreamReader reader = new StreamReader(fileName);
                //2 operaciones
               while (!reader.EndOfStream) 
               {
                    line= reader.ReadLine();
                    personList.Add(Map(line));
               } 
                //3 cerrar
                reader.Close();
                return personList;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        private Person Map(string line)
        {
            Person person = new Person();
            var vector= line.Split(',');
            person.Id = int.Parse(vector[0]);
            person.Name = vector[1];
            person.Email = vector[2];
            return person;
        }
    }
}
