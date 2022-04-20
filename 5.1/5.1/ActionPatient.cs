using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class ActionWithPatient
    {
        public int ID { get; set; }
        public string Comment;
        public virtual void Do(PatientCard patientCard)
        {
            Console.WriteLine("Введите комментарий:");
            string Comment = Console.ReadLine();
            this.Comment = Comment;
        }
        public ActionWithPatient(int id)
        {
            this.ID = id;
        }
    }
}