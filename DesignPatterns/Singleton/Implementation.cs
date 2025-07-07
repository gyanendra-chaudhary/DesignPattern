using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private static readonly Lazy<Logger> _lazyInstance = new Lazy<Logger>(() => new Logger());
        //private static Logger? _instance;
        public static Logger Instance
        {

            get
            {
               return _lazyInstance.Value;
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;
            }
        }
        protected Logger()
        {

        }
        /// <summary>
        /// SingletonOperation
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }
}
