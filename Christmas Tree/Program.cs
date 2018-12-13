using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        
        static void Main(string[] args)





        {
            int n = 0;
            do
            {
                try
                {
                    Console.Write("How long? min 5, max 10: ");
                     n = Convert.ToInt32(Console.ReadLine());

                    if (n > 10 || n < 5)
                    {
                        Console.Write("please insert  min 5, max 10: ");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        treeMake(n);
                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine("Please insert Numbers between 5 and 10");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            } while (n < 10 || n > 5);

        }


        static void treeMake(int n)//n = 9
        {
            int part = 3;
            int spase = n * part;//n(9) * part(3) = spase(27)

            int i;

            n = n / 3 * part;// n(9)/ 3 * part(3) = n(9)
            //loop for tree parts
            for ( i = 1; i <= part; i++)
            {

                //loop for 3 tree parts
                for (int i1 = 1; i1 <= n; i1++)
                {
                    // Loop For Space
                    for (int x = 1; x <= (spase - i1); x++) //spase(27)-1
                    {
                        Console.Write(" ");
                    }
                    //increase the number value
                    for (int j = 1; j <= i1; j++)
                    {
                        //Console.Write(j);
                        Console.Write('-');
                    }
                    //decrease the number value
                    for (int y = (i1 - 1); y >= 1; y--)
                    {
                        //Console.Write(y);
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
                n = n * 2;
            }

            //loop for asst
            int asst = n / 3;
            for ( i = 1; i <= asst/2; i++)
            {
                for (int x = 1; x <= asst; x++)
                {
                    Console.Write(' ');
                }
                for (int x = 1; x <= asst; x++)
                {
                    Console.Write("|");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            //wright WBS
            //W
            Console.WriteLine(  "#           #           #   #####       ####        \n" +
                                " #         # #         #    #    #    ##    ##      \n" +
                                "  #       #   #       #     #    #      #           \n" +
                                "   #     #     #     #      #####        ##        \n" +
                                "    #   #       #   #       #    #         #       \n" +
                                "     # #         # #        #    #    ##    ##      \n" +
                                "      #           #         #####       ####       ");




            Console.ReadKey();
            Console.Clear();
        }
    }
}
