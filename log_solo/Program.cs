using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace log_solo
{
    internal class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new FileInfo("../../../loggerConfig.xml"));
            _log.Info("я работаю)");
            Out();
        }
        static private void Out()
        {
            try
            {
                bool f = true;
                while (f)
                {
                    Console.WriteLine("52 или z?");
                    var s = Console.ReadLine();
                    if (s == "52")
                    {
                        Console.WriteLine("ты не наш... ты ошибка...");
                        throw new Exp52("чел, ты правда выбрал 52?? Пошел нахуй!");
                    }
                    else if (s == "z" || s == "Z")
                    {
                        Console.WriteLine("ZZZZ наш слоняра ZZZ");
                        f = false;
                    }
                    else Console.WriteLine("ты ахуел? заново");
                }
            }
            catch (Exp52 ex)
            {
                _log.Error(ex.Message);
            }

        }
    }
    class Exp52 : Exception
    {
        public Exp52() : base() { }
        public Exp52(string massage) : base(massage) { }
    }
}

