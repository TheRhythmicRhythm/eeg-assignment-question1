using System;

namespace Rhythmic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // This is Question 1
            string student;
            Console.Write(" are you are full-time or a part-time student:_"); 
            student = Console.ReadLine();
            string course;
            int credit;

            if(student == "fulltime"){
               Console.WriteLine("Whats your course of study:_");
              course = Console.ReadLine();
              Console.WriteLine(course + " Wow Thats a Good Course !");   
            }
            else if(student == "partime"){
                Console.WriteLine("How Many Credits Are You Taking:_");
                 credit  = Convert.ToInt32(Console.ReadLine());
                 if(credit >= 6){
                     Console.WriteLine("Too Much Course");
                 }
                 else if(credit < 6){
                     Console.WriteLine("Proceed to the screen");   
                 }
                
            }
           
            
        }
    }
}
