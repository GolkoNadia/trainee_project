using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace trainee_test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\\Users\\user\\Source\\Repos\\trainee_test_project\\trainee_test_project\\source.txt    
            Console.Write("Please input name of file: ");
            string path = Console.ReadLine();

            List<string> lines = new List<string>();
            
            //зчитування source.txt файла
            //Read source.txt file
            try
            {
                Console.WriteLine("Reading file");
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            
            //стрічки файлу, які відповідають послідовності Фібоначчі
            //rows that corresponds to the Fibonacci sequence
            choice_fibonacci_lines c = new choice_fibonacci_lines();
            List<string> lines_fibonachi = c.read_fib_lines(lines);

            //рядки у зворотньому вигляді 
            //revers of the rows
            reverse_str r = new reverse_str();
            
            List<string> result_str = r.reverse_line(lines_fibonachi);

            //C:\\Users\\user\\Source\\Repos\\trainee_test_project\\trainee_test_project\\output.txt    
            Console.Write("Please input name of new file: ");
            string new_path = Console.ReadLine();

            //зберігання результату до output.txt файлу
            //Save result to the new file output.txt
            try
            {
                using (StreamWriter sw = new StreamWriter(new_path, false))
                {
                    foreach(string line in result_str)
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Saving file");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
