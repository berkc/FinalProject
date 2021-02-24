using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CCS
{
    public class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
