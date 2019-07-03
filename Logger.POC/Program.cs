using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggers.POC
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            var GetDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            Console.WriteLine(GetDirectory);

            {
                var key = "b14ca5898a4e4133bbce2ea2315a1916";

               // Console.WriteLine("Please enter a secret key for the symmetric algorithm.");
                //var key = Console.ReadLine();

                Console.WriteLine("Please enter a string for encryption");
                var str = Console.ReadLine();
                var encryptedString = AesOperation.EncryptString(key, str);
                Console.WriteLine($"encrypted string = {encryptedString}");

                var decryptedString = AesOperation.DecryptString(key, encryptedString);
                Console.WriteLine($"decrypted string = {decryptedString}");

                //try
                // {
                //     int zero = 0;
                //     int result = 5 / zero;
                // }
                // catch (DivideByZeroException ex)
                // {
                //     Logger logger = LogManager.GetLogger("fileLogger");
                //     logger.Error(ex);
                // }


                Console.ReadKey();
            }
            Console.Read();
        }
    }
}
