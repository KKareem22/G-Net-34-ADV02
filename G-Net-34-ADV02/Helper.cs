using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_ADV02
{
    internal class Helper
    {
        public static void PrintList<T>(string ConditionName,List<T> list)
        {
            Console.WriteLine(new string('_',15)+ConditionName+new string('_',15));
            Console.WriteLine(string.Join("\n",list));
            Console.WriteLine();
        }
    }
}
