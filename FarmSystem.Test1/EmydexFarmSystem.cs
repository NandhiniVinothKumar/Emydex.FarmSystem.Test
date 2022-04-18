using FarmSystem.Test2;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
       public static List<string> list = new List<string>();
        public static List<string> releasedAnimals = new List<string>();
        //TEST 1
        public List<string> Enter(string animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            list.Add(animal + " has entered the Emydex");
            return list;
            
        }
     
        //TEST 2
        public void MakeNoise(List<string> animals)
        {
            foreach(string s in animals)
            {
                if (s.Contains("Cow"))
                {
                    Cow cow = new Cow();
                    cow.Talk();
                }
                if (s.Contains("Hen"))
                {
                    Hen hen = new Hen();
                    hen.Talk();
                }
                if (s.Contains("Horse"))
                {
                    Horse horse = new Horse();
                    horse.Talk();
                }
                if (s.Contains("Sheep"))
                {
                    Sheep sheep = new Sheep();
                    sheep.Talk();
                }
                
            }
            //Test 2 : Modify this method to make the animals talk
           // 
        }

        //TEST 3
        public void MilkAnimals(List<string> animals)
        {
            if (animals.Count == 0)
            {
                    Console.WriteLine("Cannot identify the farm animals which can be milked");
                
            }
            else
            {
                foreach (string s in animals)
                {
                    if (s.Contains("Cow"))
                    {
                        Console.WriteLine("Cow was milked!");
                    }

                }
            }
        }

        //TEST 4
        public List<string> ReleaseAllAnimals(List<string> animals)
        {
            if(animals.Count!=0)
            {
                foreach(string s in animals)
                {
                    if (s.Contains("Cow"))
                    {
                        releasedAnimals.Add("Cow has left the farm");

                    }
                    if (s.Contains("Hen"))
                    {
                        releasedAnimals.Add("Hen has left the farm");
                    }
                    if (s.Contains("Horse"))
                    {
                        releasedAnimals.Add("Horse has left the farm");
                    }
                    if (s.Contains("Sheep"))
                    {
                        releasedAnimals.Add("Sheep has left the farm");
                    }
                }
                list.Clear();
                if (list.Count == 0)
                    releasedAnimals.Add("Emydex Farm is now empty");
                else
                    releasedAnimals.Add("There are still animals in the farm, farm is not free");

            }
            return releasedAnimals;
          // Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}