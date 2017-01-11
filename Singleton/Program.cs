using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FileSystem.getInstance() == FileSystem.getInstance());
            Console.ReadLine();
        }
    }
}
