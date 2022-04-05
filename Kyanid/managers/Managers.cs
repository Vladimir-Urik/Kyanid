using System.Collections.Generic;

namespace Kyanid.managers
{
    public class Managers
    {
        private static readonly List<Manager> ListOfManagers = new List<Manager>();
        
        public static void Add(Kyanid kyanid, Manager manager)
        {
            manager.Init(kyanid);
            ListOfManagers.Add(manager);
        }
        
        public static void Start(Kyanid kyanid)
        {
            foreach (var manager in ListOfManagers)
            {
                manager.Start(kyanid);
            }
        }
        
        public static void Stop(Kyanid kyanid)
        {
            foreach (var manager in ListOfManagers)
            {
                manager.Stop(kyanid);
            }
        }
        
        public static T Get<T>() where T : Manager
        {
            return (T) ListOfManagers.Find(x => x is T);
        }
    }
}