using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_a_Ten_Minute_Walk
{
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            int nwlak = 0;
            int swlak = 0;
            int wwlak = 0;
            int ewlak = 0;

            if (walk.Length != 10)
                return false;
            else
            {
                foreach(var s in walk)
                {
                    if (s == "n")
                        nwlak++;
                    else if (s == "s")
                        swlak++;
                    else if (s == "w")
                        wwlak++;
                    else if (s == "e")
                        ewlak++;
                }

                if (nwlak == swlak && wwlak == ewlak)
                    return true;
                else
                    return false;
            }
        }
    }
}
