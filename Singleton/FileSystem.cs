using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class FileSystem
    {
        static private FileSystem instance;
        static public FileSystem getInstance()
        {
            if(instance == null)
            {
                instance = new FileSystem();

            }

            return instance;
        }

        private FileSystem()
        {

        }

    }
}
