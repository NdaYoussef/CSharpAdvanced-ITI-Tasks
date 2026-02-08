using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChanllengeIndexers
{
    internal class SecretSafe
    {
        string[] secrets = new string[10];


        //safe[0] = "My Secret"
        public string this[int index]
        {
            get
            {
                for (int i = 0; i < secrets.Length; i++)
                {
                    if (index == i)
                        return secrets[i];
                }
                return "Access Denied: Invalid Vault Key";
            }

            set
            {
                for (int i = 0; i < secrets.Length; i++)
                {
                    if (index == i)
                        secrets[index] = value;
                }

                return;

            }
        }

        public int this[string secret]
        {
            get
            {
                for(int i = 0;i<secrets.Length;i++)
                {
                    if(secrets[i] == secret)
                        return i;
                }

                return -1;
            }

            //  SecretSafe["secret1"] = 1; 


            //set
            //{
            //    for (int i = 0; i < secrets.Length; i++)
            //    {
            //        if (secrets[i] == secret)
            //            secrets[i] = value.ToString();
            //    }
            //}
}
        }
    }

