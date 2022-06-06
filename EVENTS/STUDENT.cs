using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_TRAINING.EVENTS
{
    public delegate void Mydel();
    public class STUDENT
    {
        public event Mydel Fail;
        public event Mydel Distinction;
        public void AcceptMarks(int marks)
        {
            if (marks < 40)
            {
                Fail();
            }
            else if (marks >= 75)
            {
                Distinction();
            }
            Console.WriteLine($"Your Score in {marks}");
        }
    }
        class program
        {
            static void FailMsg()
            {
                Console.WriteLine("You Are FAil");
            }
            static void DistinctionMsg()
            {
                Console.WriteLine(" Congratulation !. You Are Pass With Distinction");
            }
            static void Main(string[] args)
            {
                STUDENT s1 = new STUDENT();
                s1.Fail += new Mydel(FailMsg);
                s1.Distinction += new Mydel(DistinctionMsg);
                s1.AcceptMarks(75);
            }

        

       
        }
   
}
