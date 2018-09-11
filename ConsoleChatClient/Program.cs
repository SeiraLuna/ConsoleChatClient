using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChat
{
    class ClientProgram
    {
        static void Main(string[] args)
        {
            var ConsoleChatClient = new Client(new ClientConfiguartion().Initialize());
            ConsoleChatClient.Initialize();

            Console.ReadKey();
        }
    }
}
