using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_CS
{
    internal class Manager
    {

        private Manager() { }
    

        private readonly static Manager _INSTANCE = new Manager();

        public static Manager INSTANCE
        {
            get { return _INSTANCE; }

        }

        Hashtable tbl = new Hashtable();

        public void LoadTable()
        {

            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i < 1000; i++)
            {
                int randomNum = random.Next(1, 5);
                if (randomNum % 2 == 0)
                {
                    Falafel yossi = new Falafel(randomNum);
                    yossi.numfalafelballs = random.Next(100, 10000);
                    object o = tbl[yossi.Id];
                    Falafel num = (Falafel)o;
                    if (!(tbl[yossi.Id] is Falafel))
                    {
                        tbl.Add(yossi.Id, yossi);
                    }
                    else
                    {
                        Console.WriteLine("the id already exsit");
                    }

                }
                else
                {
                    IceCream Golda = new IceCream(randomNum);
                    Golda.numIceCreamBall = random.Next(1, 5);


                    if (!(tbl[Golda.Id] is IceCream))
                    {
                        tbl.Add(Golda.Id, Golda);
                    }
                    else
                    {
                        Console.WriteLine("the id already exsit");
                    }

                }


            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("please enter a number between 100 to 9999");
                string numUser = Console.ReadLine();
                int userResponse = int.Parse(numUser);

                if (tbl[userResponse] is Falafel)
                {
                    Console.WriteLine($"this falafel has {((Falafel)tbl[userResponse]).numfalafelballs}");
                }
                else if (tbl[userResponse] is IceCream)
                {
                    Console.WriteLine($"this iceCream has {((IceCream)tbl[userResponse]).numIceCreamBall}");
                }
                else
                {
                    Console.WriteLine("the number dosent exsit in the table");
                }
            }
        }

    }
}
