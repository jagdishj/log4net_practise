using System;

namespace Log4Net_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            log.Info("INFO Log");
            log.Debug("Debug Log");
            log.Warn("Warn Log");
            log.Error("Error Log");

            Console.WriteLine("Hello World!");

        }
    }
}
