using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Questions
            string[] questions =
            {
                "How many planetsn are there in our galaxy?",
                "How many heuman blood type? ",
                "How many Arab countries are there ? ",


            };
            // Create Answers
            string[] Answer =
            {
                "A. 6 \nB. 8 \nC. 9 \nD. 10",
                "A. 7 \nB. 5 \nC. 4 \nD. 3",
                "A. 25  \nB. 30 \nC. 32 \nD. Noun of them",
                
            };
            int[] CorrectAnswers = {2,2,0 };
            int playerScore = 0;
            Console.WriteLine("Welcom to the best Quiz App ever :) ");
            for(int i=0; i < questions.Length; i++)
            {
                Console.WriteLine("Question "+(i+1));
                Console.WriteLine(questions[i]);
                Console.WriteLine(Answer[i]);
                Console.Write("Please Enter your answer [A ,B , C ,OR D]:");
                string playerAnswer = Console.ReadLine();

                //Validating Answers 
                if (string.Equals(playerAnswer,"A",StringComparison.OrdinalIgnoreCase)&&CorrectAnswers[i]==0)
                {
                    playerScore++;
                }
                else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && CorrectAnswers[i] == 1)
                {
                    playerScore++;
                }
                else if (string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && CorrectAnswers[i] == 2)
                {
                    playerScore++;
                }
                else if (string.Equals(playerAnswer, "D", StringComparison.OrdinalIgnoreCase) && CorrectAnswers[i] == 3)
                {
                    playerScore++;
                }
            }
            //Print score out to user
            Console.WriteLine("Quiz completed :)");
            Console.WriteLine("your score is: " + playerScore + "/" + questions.Length);
            Console.ReadKey();
        }
    }
}
