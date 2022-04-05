using System.Collections.Generic;
using Kyanid.managers;

namespace Kyanid
{

    public class SettingsManager : Manager
    {
        
        private Dictionary<string, Dictionary<string, object>> _settings = new Dictionary<string, Dictionary<string, object>>();

        public void Init(Kyanid kyanid)
        {
            
        }

        public void Start(Kyanid kyanid)
        {
            
        }

        public void Stop(Kyanid kyanid)
        {
            
        }
        
        public void SetSettings(Module module, Dictionary<string, object> settings)
        {
            if (!_settings.ContainsKey(module.Name()))
            {
                _settings.Add(module.Name(), settings);
            }
            else
            {
                _settings[module.Name()] = settings;
            }
        }
        
        public void SetSetting(Module module, string key, object value)
        {
            if (!_settings.ContainsKey(module.Name()))
            {
                _settings.Add(module.Name(), new Dictionary<string, object>());
            }
            if(!_settings[module.Name()].ContainsKey(key))
            {
                _settings[module.Name()].Add(key, value);
            }
            else
            {
                _settings[module.Name()][key] = value;
            }
        }
        
        public T GetSetting<T>(Module module, string key)
        {
            if (!_settings.ContainsKey(module.Name()))
            {
                return default(T);
            }
            if (!_settings[module.Name()].ContainsKey(key))
            {
                return default(T);
            }
            return (T) _settings[module.Name()][key];
        }

    }
}