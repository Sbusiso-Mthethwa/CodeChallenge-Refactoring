using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenge
{
    public class Developer
    {
        public const int SERIOUSNESS_WEIGHT = 10;
        public const int COLLABORATION_WEIGHT = 10;
        public const int WORKING_HOURS_WEIGHT = 5;
        public const int LEVEL_OF_COMMUNICATION = 5;


        public string Name { get; set; }
        public bool IsSerious { get; set; }
        public bool EnjoysCollaboration { get; set; }
        public int HoursWorked { get; set; }
        public Enum.CommunicationLevel LevelOfCommunication { get; set; }
        public int Bias { get; set; }

        public Developer(
            String name,
            bool isSerious,
            bool enjoysCollaboration,
            int hoursWorked,
            Enum.CommunicationLevel levelOfCommunication
        )
        {
            Name = name;
            IsSerious = isSerious;
            EnjoysCollaboration = enjoysCollaboration;
            HoursWorked = hoursWorked;
            LevelOfCommunication = levelOfCommunication;

            if (Name.Equals("Sbusiso", StringComparison.InvariantCultureIgnoreCase))
            {
                Bias = 2;
            }
            else
            {
                Bias = 1;
            }

        }

        public int Fitness()
        {
            int fitness = Bias * (HoursWorked * WORKING_HOURS_WEIGHT)
                    + Bias * (((int)LevelOfCommunication) * LEVEL_OF_COMMUNICATION);
            if (IsSerious)
            {
                fitness += Bias * SERIOUSNESS_WEIGHT;
            }
            if (EnjoysCollaboration)
            {
                fitness += Bias * COLLABORATION_WEIGHT;
            }
            return fitness;
        }

        override
        public String ToString()
        {
            return "Developer {" +
                    "\n\n\tName = " + Name +
                    ",\n\tIsSerious = " + IsSerious +
                    ",\n\tEnjoysCollaboration = " + EnjoysCollaboration +
                    ",\n\tNumberOfWorkingHours = " + HoursWorked +
                    ",\n\tLevelOfCommunication = " + LevelOfCommunication +
                    ",\n\tBias = " + Bias +
                    ",\n\tFitness = " + Fitness() +
                    "\n}";
        }

    }

}
