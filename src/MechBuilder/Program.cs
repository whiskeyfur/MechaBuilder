using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MechBuilder {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            foreach (Type t in Assembly.LoadFile(Environment.CurrentDirectory + "\\Classes.dll").GetTypes()) {
                Console.WriteLine(t.Name);
            }
            // Start the form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
