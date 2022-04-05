using System.Collections.Generic;
using Kyanid.managers;

namespace Kyanid
{
    public class ModulesManager : Manager 
    {
        private readonly List<Module> _modules = new List<Module>();
        
        public void Init(Kyanid kyanid)
        {
            kyanid.GetLogger().Log("Initialising ModulesManager");
            _modules.Add(new AutoClicker(kyanid));
            kyanid.GetLogger().Log("Modules registered!");
        }

        public void Start(Kyanid kyanid)
        {
            foreach (var module in _modules)
            {
                module.Init();
                module.Start();
            }
        }

        public void Stop(Kyanid kyanid)
        {
            foreach (var module in _modules)
            {
                module.Stop();
            }
        }
        
        public Module GetModule(string name)
        {
            return _modules.Find(x => x.Name() == name);
        }
    }
}