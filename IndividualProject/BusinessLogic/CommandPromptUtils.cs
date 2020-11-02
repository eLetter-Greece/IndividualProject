using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils
    {

        public Trainer GetTrainerDetails()
        {
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Give me your first name");
            trainer.LastName  = AskDetail("Give me your last name");
            trainer.Subject   = AskDetail("Give me the subject you teach");
            return (trainer);
        }

        private string AskDetail(string message)
        {
            string result = "";
            Console.Write(message + ": ");
            result = Console.ReadLine();
            return (result);
        }

        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
