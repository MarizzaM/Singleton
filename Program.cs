using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWThreadLocksAndMonitor
{
    class Program
    {
        public class Singleton
        {
            private static Singleton Instance;
            private static object key = new object();
            public static Singleton GetInstance()
            {
                if (Instance == null)
                {
                    lock (key)
                    {
                        if (Instance == null)
                        {
                            Instance = new Singleton();
                        }
                    }
                }
                return Instance;
            }

            private Singleton()
            {

            }

            public DateTime GetTime()
            {
                return DateTime.Now;
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine(Singleton.GetInstance().GetTime());

        }
    }
}
