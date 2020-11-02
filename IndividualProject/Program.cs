using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
using IndividualProject.BusinessLogic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            //Trainer trainer =  cpUtils.GetTrainerDetails();
            //Console.WriteLine(trainer);

            //Trainer trainer2 = cpUtils.GetTrainerDetails();
            //Console.WriteLine(trainer2);

            List<Trainer> trainers = new List<Trainer>();
            trainers.Add(cpUtils.GetTrainerDetails());
            //trainers.Add(cpUtils.GetTrainerDetails());
            //trainers.Add(cpUtils.GetTrainerDetails());
            cpUtils.PrintTrainersList(trainers);

        }

        // Create appropriate methods in order to ask 
        // from the user data for the four main classes
    }
}
