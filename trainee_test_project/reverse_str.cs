using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainee_test_project
{
    public class reverse_str
    {
        //return revers of the rows 
        public List<string> reverse_line(List<string> str_only_fib)
        {
            List<string> result_str = new List<string>();

            for (int i = 0; i < str_only_fib.Count; i++)
            {
                char[] array = str_only_fib[i].ToCharArray();

                for (int j = 0; j < array.Length; j++)
                {
                    for (int k = array.Length - 1 - j; k < j; k--)
                    {
                        char c = array[j];
                        array[j] = array[k];
                        array[k] = c;
                        break;
                    }
                }

                result_str.Add(new string(array));
            }
            return result_str;
        }

    }
}
