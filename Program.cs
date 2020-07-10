using System;

namespace Soundex
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Date of Birth, 'DDMMYYYY') || SexID || FirstName || Surname
            var student1dob = "30122000";
            var student1sexid = "01";
            var student1fname = "BOB";
            var student1surname = "SMITH";
            var student1 = student1dob + student1sexid + Soundex.Generate(student1fname) + Soundex.Generate(student1surname);

            var student2dob = "30122000";
            var student2sexid = "01";
            var student2fname = "BOB";
            var student2surname = "SMYTH";
            var student2 = student2dob + student2sexid + Soundex.Generate(student2fname) + Soundex.Generate(student2surname);

            if(student1 == student2)
            {
                Console.WriteLine(student1);
                Console.WriteLine(student2);
                Console.WriteLine("Looks like a match");
            }
            else
            {
                Console.WriteLine("Looks like students are different.");
            }
            Console.ReadLine();
        }
    }
}