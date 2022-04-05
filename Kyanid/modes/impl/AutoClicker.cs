using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Kyanid.managers;
using Kyanid.utils;

namespace Kyanid
{
    public class AutoClicker : Module
    {
        private const int LeftDown = 0x201;
        private const int LeftUp = 0x202;

        private Thread _thread;
        private Kyanid _kyanid;
        private bool _running;

        public AutoClicker(Kyanid kyanid)
        {
            this._kyanid = kyanid;
        }

        public string Name()
        {
            return "AutoClicker";
        }
        
        public void Init()
        {
            var config = new Dictionary<string, object>
            {
                ["minCps"] = 10,
                ["maxCps"] = 12,
                ["attackRequired"] = true
            };
            Managers.Get<SettingsManager>().SetSettings(this, config);
            Console.WriteLine("AutoClicker initialized");
        }

        public void Start()
        {
            _thread = new Thread(StartClicker);
            _thread.Start();
            Console.WriteLine("AutoClicker started");
            _running = true;
        }

        public void Stop()
        {
            if(!_running) return;
            
            _thread.Abort();
            Console.WriteLine("AutoClicker stopped");
            _running = false;
        }

        private void SendClick(IntPtr hWnd)
        {
            User32Utils.SendMessage(hWnd, LeftDown, 0, 0);
            User32Utils.SendMessage(hWnd, LeftUp, 0, 0);
        }

        private void StartClicker()
        {
            var settingsManager = Managers.Get<SettingsManager>();
            var hWnd = User32Utils.FindWindow(null, _kyanid.GetMinecraftProcess().MainWindowTitle);
            
            while (true)
            {
                if (settingsManager.GetSetting<bool>(this, "attackRequired") && Control.MouseButtons != MouseButtons.Left)
                {
                    continue;
                }

                var cps = new Random().Next(settingsManager.GetSetting<int>(this, "minCps"), settingsManager.GetSetting<int>(this, "maxCps"));
                var ms = 1000 / cps;
                for(var i = 0; i < cps; i++)
                {
                    SendClick(hWnd);
                    Thread.Sleep(ms);
                }
            }
        }
        
        public bool IsRunning()
        {
            return _running;
        }
    }
}