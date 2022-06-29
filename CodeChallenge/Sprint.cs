using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChallenge
{
    public class Sprint
    {
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

        public Sprint()
        {
            foreach (String dev in devsNames)
            {
                Random rn = new Random();
                int tempIsSerious = rn.Next(0,2);
                int tempEnjoysCollaboration = rn.Next(0,2);
                int tempWorkingHours = rn.Next(91);
                int tempLevelOfSelfAwareness = rn.Next(1, 6);
                int tempLevelOfCommunication = rn.Next(1, 4);

                Developer developer = new Developer(
                        dev,
                        tempIsSerious == 1 ? true : false,
                        tempEnjoysCollaboration == 1 ? true : false,
                        tempWorkingHours,
                        tempLevelOfSelfAwareness,
                        tempLevelOfCommunication
                );
                Developers.Add(developer);
            }
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
