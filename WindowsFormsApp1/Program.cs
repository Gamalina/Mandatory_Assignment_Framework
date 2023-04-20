using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Making an DI(dependency injection) framework so an instance of ILogger<World> will be injected into Form1 when it is created
            var serviceProvider = new ServiceCollection().AddLogging(loggingbuilder =>
            {
                loggingbuilder.AddConsole();
            })
                .AddTransient<Form1>()
                .BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}
