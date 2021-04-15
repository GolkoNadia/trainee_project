using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace trainee_test_project
{
    public class Work_with_file
    {
        //return all rows that corresponds to the Fibonacci sequence
        public List<string> read_fib_lines(string[] lines_of_file)
        {
            List<int> fib = new List<int>();

            for (int i = 1; i < lines_of_file.Length; i++)
            {
                if (Fibonacci(i) < lines_of_file.Length)
                {
                    fib.Add(Fibonacci(i));
                }
            }

            List<string> str_only_fib = new List<string>();
            for (int i = 0; i < lines_of_file.Length; i++)
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

        //return revers of the rows 
        public List<string> reverse_line(List<string> str_only_fib)
        {
            List<string> result_str = new List<string>();

            for (int i = 0; i < str_only_fib.Count; i++)
            {
                char[] array = str_only_fib[i].ToCharArray();
                string res = "";
                for (int j = array.Length - 1; j >= 0; j--)
                {
                    res += array[j];
                }
                result_str.Add(res);
            }
            return result_str;
        }

        //calculate Fibonacci Sequence
        public int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }
            return a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../source.txt";
            string[] lines = new string[] { };

            //зчитування source.txt файла
            //Read source.txt file
            try
            {
                lines = File.ReadAllLines(path);
                Console.WriteLine("Reading file");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Work_with_file work_with_file = new Work_with_file();

            //стрічки файлу, які відповідають послідовності Фібоначчі
            //rows that corresponds to the Fibonacci sequence
            List<string> lines_fibonachi = work_with_file.read_fib_lines(lines);

            //рядки у зворотньому вигляді 
            //revers of the rows
            List<string> result_str = work_with_file.reverse_line(lines_fibonachi);

            //зберігання результату до output.txt файлу
            //Save result to the new file output.txt
            Console.WriteLine("Saving file");
            File.WriteAllLines("../../output.txt", result_str);
        }
    }
}
