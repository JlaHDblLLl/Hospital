using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class BobBuilder
    {
        public BobBuilder(Patient patient)
        {
            Repository<PatientCard> repositoryOfPatientsCards = new Repository<PatientCard>(new PatientCard[] {
            new PatientCard(0, new Patient(0, "Вася", "Пупкин", new Adress("Гаспадарчая", "23")), new Repository<Record>( new List<Record>() )),
            new PatientCard(1, new Patient(1, "Егор", "Валерьевич", new Adress("Янки Купалы", "16")), new Repository<Record>( new List<Record>() )),
            new PatientCard(2, new Patient(2, "Максим", "Ланцевич", new Adress("Кабяка", "56")), new Repository<Record>( new List<Record>() )),
            new PatientCard(4, new Patient(4, "Катя", "Валуева", new Adress("Кабяка", "34")), new Repository<Record>( new List<Record>() ))
            }
            );

            Repository<Employee> repositoryOfEmployees = new Repository<Employee>(new Employee[] {
            new DutyDoctor("Виталик", new Adress("Кабяка", "14"),new Repository<ActionWithPatient>( new ActionWithPatient[] { new Redirect(), new WriteRecipe() })),
            new DutyDoctor("Роман", new Adress("Гаспадарчая", "100"), new Repository<ActionWithPatient>(new ActionWithPatient[] { new Redirect(), new WriteRecipe() })),
            new Doctor("Милена", new Repository<ActionWithPatient>( new ActionWithPatient[] { new Redirect(), new WriteRecipe(), new Heal()})),
            new Doctor("Карл",new Repository<ActionWithPatient>( new ActionWithPatient[] { new Redirect(), new WriteRecipe(), new Heal()})),
            new MainDoctor("Виктор", new Repository<ActionWithPatient>(new ActionWithPatient[] { new Redirect(), new WriteRecipe(), new WriteOut() }))
            }
            );
            EmployeeHandler employeeHandler = new EmployeeHandler(repositoryOfEmployees);
            PatientCardHandler patientCardHandler = new PatientCardHandler(repositoryOfPatientsCards);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Reception reception = new Reception(patientCardHandler, employeeHandler, new Queue<Patient>(new Patient[] { patient }));
            reception.PatientPerformance();

        }
    }
}