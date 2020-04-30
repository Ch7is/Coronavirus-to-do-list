using System;

/************************
Just messing about with code i've learnt
and to make a basic random to do list while on Coronavirus lockdown
*************************/

namespace Visual_Studio
{
    class Today 
    {
    
     public  Random random = new Random();
     public  DateTime date = DateTime.Now;
     
       
     public string [] category = {"Watch You Tube for 3 hours","code for 3 hours", "Watch Star Trek for 3 hours", "Exercise for at least half hour","Read for 3 hours", "watch Spooks for 3 hours","Hoover the house", "Vanish front door", "Learn SQL for 3 hours"};
        
       
     public void whatToWatch()
            {
           
        int ran =  random.Next(category.Length);
            Console.WriteLine($"Its {date.DayOfWeek} , I will {category[ran]}");
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Today thingsToDo = new Today();
            thingsToDo.whatToWatch();
        }
    }
}
