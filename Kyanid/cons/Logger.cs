using System;

namespace Kyanid
{
    public class Logger
    {
        private readonly string _name;
        
        public Logger(string name)
        {
            _name = name;
        }
        
        public void Log(string message)
        {
            Console.WriteLine($"[{_name}]: {message}");
        }
        
        public void Log(string message, params object[] args)
        {
            Console.WriteLine($"[{_name}]: {string.Format(message, args)}");
        }
        
        public void Log(Exception ex)
        {
            Console.WriteLine($"[{_name}]: {ex.Message}");
        }
        
    }
}