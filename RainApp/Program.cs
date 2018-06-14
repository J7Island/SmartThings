using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.PSharp;


namespace RainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = Configuration.Create().WithVerbosityEnabled(2);
            var runtime = PSharpRuntime.Create(configuration);
            Program.Execute(runtime);
            Console.WriteLine("Press Enter to terminate...");
            Console.ReadLine();

        }

        [Microsoft.PSharp.Test]
        public static void Execute(PSharpRuntime runtime)
        {
            runtime.CreateMachine(typeof(NetworkEnvironment));
        }
    }
}
