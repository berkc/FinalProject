using System;

namespace Business.CCS
{
    public class DatabaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("VeriTabanına loglandı");
        }
    }
}
