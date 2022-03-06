using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    public class ActionWithPatientController
    {
        // используется в Employee.Action
        List<ActionWithPatient> actionWithPatient = new List<ActionWithPatient>();

        public ActionWithPatientController(ActionWithPatient action)
        {
            actionWithPatient.Add(action);
        }
    }
}