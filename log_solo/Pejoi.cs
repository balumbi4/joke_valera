using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log_solo
{
    internal class Pejoi
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Pejoi));
        public Pejoi() 
        {
            XmlConfigurator.Configure(new FileInfo("../../../loggerConfig.xml"));
            _log.Info("Класс Pejoi создан.");
        }

    }
}
