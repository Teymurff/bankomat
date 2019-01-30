using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[6];
            nums[0] = 100;
            nums[1] = 50;
            nums[2] = 20;
            nums[3] = 10;
            nums[4] = 5;
            nums[5] = 1;

            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 1; k++)
                {

                    for (int l = 0; l < 1; l++)
                    {

                        for (int m = 0; m < 1; m++)
                        {

                            for (int n = 0; n < 1; n++)

                            {
                                for (int p = 0; p < 6; p++)
                                {

                                    Console.WriteLine(nums[0]);
                                }

                                Console.WriteLine(nums[1]);
                            }

                            Console.WriteLine(nums[2]);
                        }

                        Console.WriteLine(nums[3]);
                    }

                    Console.WriteLine(nums[4]);
                }

                Console.WriteLine(nums[5]);
                Console.WriteLine(nums[5]);
                break;

            }          
            
            Console.ReadLine();
        }
    }
}
