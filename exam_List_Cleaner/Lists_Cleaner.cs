using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_List_Cleaner
{
    public static class Lists_Cleaner
    {
        public static ArrayList Clean_strings(ArrayList list)
        {
           ArrayList cleanList = new ArrayList();
           int size = list.Count;
            for (int i = 0; i <size; i++) 
            {

              if (list[i] is int || list[i] is long || list[i] is float || list[i] is double || list[i] is decimal || list[i] is byte
                    || list[i] is short || list[i] is sbyte || list[i] is ushort || list[i] is uint || list[i] is ulong)
                {
                    cleanList.Add(list[i]);
                }
              else if (int.TryParse(list[i].ToString(), out int variabla))
              {
                    cleanList.Add((int)variabla);
              }
            }
            return cleanList;
        }

        public static decimal SumOfAllElements(ArrayList list)
        {
            decimal sum = 0;
            int size = list.Count;
            foreach (object element in list)
            {
                if (element is  decimal)
                {
                    sum += (decimal)element;
                }
                else if (element is long)
                {
                    sum += (decimal)element;
                }
                else if (element is float)
                {
                    sum += (decimal)element;
                } 
                else if (element is double)
                {
                    sum += (decimal)element;
                }
                else if ( element is int)
                {
                    sum += (int)element;
                }
            }
            return sum;
        }
    }
}
