using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenge
{
    public class Sprint
    {
        public static Sprint sprint;
        public static String[] devsNames = {
            "Gabriel",
            "Joshua",
            "Petrus",
            "Zakaria",
            "Dale",
            "Skhumbuzo",
            "Graeme",
            "Sbusiso",
            "Luke"
        };

        private List<Developer> Developers = new List<Developer>();

        private Sprint()
        { 
            Random rn = new Random();
            foreach (String dev in devsNames)
            {
                int tempIsSerious = rn.Next(0,2);
                int tempEnjoysCollaboration = rn.Next(0,2);
                int hoursWorked = rn.Next(81);
                Enum.CommunicationLevel tempLevelOfCommunication = (Enum.CommunicationLevel)rn.Next(1, 4);

                Developer developer = new Developer(
                        dev,
                        tempIsSerious == 1 ? true : false,
                        tempEnjoysCollaboration == 1 ? true : false,
                        hoursWorked,
                        tempLevelOfCommunication
                );
                Developers.Add(developer);
            }
        }

        public static Sprint GetInstance()
        {
            if (sprint == null)
                sprint = new Sprint();
            return sprint;
        }

        public Developer GetBestDeveloper()
        {
            Developer bestDev = Developers[0];
            foreach (Developer dev in Developers)
            {
                if (dev.Fitness() > bestDev.Fitness())
                {
                    bestDev = dev;
                }
            }
            return bestDev;
        }

        public void PrintDevelopers()
        {
            foreach (Developer dev in Developers)
            {
                Console.WriteLine(dev.ToString() + "\n");
            }
        }
    }
}
