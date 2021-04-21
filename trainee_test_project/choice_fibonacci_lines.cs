using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainee_test_project
{
    public class choice_fibonacci_lines
    {
        //return all rows that corresponds to the Fibonacci sequence
        public List<string> read_fib_lines(List<string> lines_of_file)
        {
            Fibonacci f = new Fibonacci();

            List<int> fib = new List<int>();

            for (int i = 1; i < lines_of_file.Count; i++)
            {
                if (f.calculate_Fibonacci(i) <= lines_of_file.Count)
                {
                    fib.Add(f.calculate_Fibonacci(i));
                }
            }

            List<string> str_only_fib = new List<string>();
            for (int i = 0; i < lines_of_file.Count; i++)
            {
                for (int j = 0; j < fib.Count; j++)
                {
                    if (i + 1 == fib[j])
                    {
                        //Console.WriteLine($"Fibonachi={fib[j]} lines {i + 1} \n {lines_of_file[i]}");
                        str_only_fib.Add(lines_of_file[i]);
                    }
                }
            }
            return str_only_fib;
        }
    }
}
