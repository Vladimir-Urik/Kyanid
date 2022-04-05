using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Kyanid.gui;
using Kyanid.managers;

namespace Kyanid
{
    public class Kyanid
    {
        private Logger _logger;
        private Process _process;

        private static void Main(string[] args)
        {
            var kyanid = new Kyanid();
            kyanid.Start();
        }

        private void Start()
        {
            _logger = new Logger("Kyanid");

            _process = Process.GetProcessesByName("javaw").FirstOrDefault();
            if (_process == null)
            {
                Console.WriteLine("Process not found :C");
                Console.ReadLine();
                return;
            }
            // TODO: Bind manager to disable/enable cheats
            
            Managers.Add(this, new SettingsManager());
            Managers.Add(this, new ModulesManager());

            Managers.Start(this);
            StartGui();
            Console.ReadLine();
        }

        public void Stop()
        {
            Managers.Stop(this);
            Environment.Exit(0);
        }
        
        public Process GetMinecraftProcess()
        {
            return _process;
        }
        
        public Logger GetLogger()
        {
            return _logger;
        }

        private void StartGui()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CheatMenu(this));
        }
    }
}