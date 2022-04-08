using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);

            }

            Console.ReadLine();
        }

        private static void Find()
        {
            List<string> student = new List<string> { "Engin", "miko", "kerim" };
            if (!student.Contains("ahmet"))
            {
                throw new RecordNotFoundException ("record not found");
            }
            else
            {
                Console.WriteLine("record found");
            }
        }
    }
}
