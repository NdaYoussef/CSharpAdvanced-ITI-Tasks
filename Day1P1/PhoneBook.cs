using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1P1
{
    internal class PhoneBook
    {
        public string[] Names = new string[10]; // new string[3];
        public int[] Numbers = new int[10];



            public int this[string name]
            {
            get
            {
                for(int i = 0; i < Names.Length; i++)
                {
                    if (name == Names[i])
                      return Numbers[i];
                }
                return -1;
            }

            set
            {
                for(int i = 0;i < Numbers.Length;i++)
                {
                    if (Names[i] is null)
                    {
                        Names[i] = name;
                        Numbers[i] = value;
                        return;
                    }
                    else if (name == Names[i])
                    { 
                        Numbers[i] = value;
                        return;
                    }
                }
            }
            }

        public string this[int number]
        {
            get
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    if (number == Numbers[i])
                        return Names[i];
                }
                return "not matched!";
            }

            set
            {
                for(int i = 0; i<Numbers.Length; i++)
                { 
                    if (number == Numbers[i])
                    {
                        if (number > 0)
                        {
                            Names[i] = value;
                            return;
                        }
                    }
                    else
                    {
                        if(number > 0)
                        {
                            Numbers[i] = number;
                            Names[i] = value;
                            return;
                        }
                       
                    }
                }
            }
        }


    }
}
