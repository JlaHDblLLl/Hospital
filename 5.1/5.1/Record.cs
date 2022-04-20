using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class Record //TODO: система наследования класса Record(разные записи могут быть: Рецепт, диагноз, приписка для перенаправления)
    {
        public string Diagnose { get; set; }
        public string Comment { get; set; }
        public Record(string diagnose, string comment)
        {
            Diagnose = diagnose;
            Comment = comment;
        }
        public Record(string comment)
        {
            Comment = comment;
        }
    }
}