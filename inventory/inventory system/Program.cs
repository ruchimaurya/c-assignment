using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> listofitems = new List<List<string>>();
            listofitems.Add(new List<string> { "lettuce", "10.5", "50", "Leafy green" });
            listofitems.Add(new List<string> { "cabbage", "20", "100", "Cruciferous" });
            listofitems.Add(new List<string> { "pumpkin", "30", "30", "Marrow "});
            listofitems.Add(new List<string> { "cauliflower", "10", "25", "Cruciferous" });
            listofitems.Add(new List<string> { "zucchini", "20.5", "50","Marrow" });
            listofitems.Add(new List<string> { "yam", "30", "50", "Root "});
            listofitems.Add(new List<string> { "spinach", "10", "100", "Leafy green" });
            listofitems.Add(new List<string> { "broccoli", "20.2", "75", "Cruciferous" });
            listofitems.Add(new List<string> { "Garlic", "30", "20", "Leafy green" });
            listofitems.Add(new List<string> { "silverbeet", "10", "50", "Marrow" });

            var count = listofitems.Count();
            //add potato
            Console.WriteLine("Total number of products in list:" + count);
            listofitems.Add(new List<string> { "Potato", "10RS", "50", "Root" });

            //display list
            foreach (var  i in listofitems)
            {
                foreach(var j in i)
                {
                    Console.Write(j);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            count = listofitems.Count();

            Console.WriteLine("Total number of products in list:" + count);

            var dellist = listofitems.ToList();
            //print items contain leafy green
            foreach (var i in listofitems)
            {
                foreach (var j in i)
                {
                    if(j== "Leafy green")
                    {
                        foreach(var k in i)
                        {
                            Console.Write(k + "  ");
                            
                        }
                        Console.WriteLine();

                    }
                    
                }


            }


            int counter = 0;
            foreach (var i in dellist)
            {

                foreach (var j in i)
                {
                   if(j== "Garlic")
                    {
                        listofitems.RemoveAt((counter));
                        counter=counter-1;
                    }
                        
                }
                Console.WriteLine();
                counter++;
            }

            foreach (var i in listofitems)
            {
                foreach (var j in i)
                {
                    Console.Write(j);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            //add 50 cabbages

            foreach (var i in listofitems)
            {
                foreach (var j in i)
                {
                    if (j == "cabbage")
                    {
                        var k = listofitems[listofitems.IndexOf(i)][2];
                            int num;
                            if(int.TryParse(k, out num))
                            {
                                num = num + 50;

                                Console.WriteLine(num);

                            }
                    }
                }
            }

            Console.WriteLine(listofitems[0][1]);

            float prc1 = counttotal("lettuce",1);
            float prc2 = counttotal("zucchini", 2);
            float prc3 = counttotal("broccoli",1);

            float total = prc1 + prc2 + prc3;

            int final = (int)Math.Round(total);

            Console.WriteLine("Total Price:" +total);

            Console.Read();

            //billing
            
            float counttotal(string item, int qty)
            {
                float tot=0;

                foreach (var i in listofitems)
                {
                    foreach (var j in i)
                    {
                        if (j == item)
                        {
                            var k = listofitems[listofitems.IndexOf(i)][1];
                            float prc;
                            if (float.TryParse(k, out prc))
                            {

                                tot = prc*qty;

                                Console.WriteLine(tot);
                              

                            }
                        }
                    }
                }
                return tot;
            }
         

        }
 
    }
}
