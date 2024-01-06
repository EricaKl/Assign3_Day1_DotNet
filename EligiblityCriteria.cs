using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assign3
{
    internal class EligiblityCriteria
    {
        public void Eligibility(float Physics, float Chemistry, float Maths)
        {
            if(Physics >=55)
            {
                if(Maths>=65)
                {
                    if(Chemistry>=50)
                    {
                        if((Physics + Chemistry+Maths)>=180 || (Maths+Physics)>=140)
                        {
                            Console.WriteLine("The candidate is Eligiblefor admission");

                        }
                        else
                        {
                            Console.WriteLine("The candidate is not eligible for admission");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The candidate is not eligible for admission");
                    }
                }
                else
                {
                    Console.WriteLine("The candidate is not eligible for admission");
                }
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
        }

        static void Main()
        {
            float Physics, Chemistry, Maths, Total;
            Console.WriteLine("Enter Physics Marks ");
            Physics = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chemistry Marks ");
            Chemistry = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks ");
            Maths = float.Parse(Console.ReadLine());

            EligiblityCriteria e = new EligiblityCriteria();
            e.Eligibility(Physics,Chemistry, Maths);
        }
    }
}
