using System;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator
{
    private static readonly Dictionary<string, IService> _services = new Dictionary<string, IService>();

    public static void RegisterService<T>(T service) where T : IService
    {
        string key = typeof(T).Name;
        if (_services.ContainsKey(key))
        {
            Debug.LogError("Attempting to register service that already exists");
            return;
        }

        _services.Add(key, service);
    }

    public static void UnregisterService<T>() where T : IService
    {
        string key = typeof(T).Name;
        if (!_services.ContainsKey(key))
        {
            Debug.LogError("Attempting to unregister service that does not exist");
            return;
        }

        _services.Remove(key);
    }

    public static T GetService<T>() where T : IService
    {
        string key = typeof(T).Name;
        if(!_services.ContainsKey(key))
        {
            Debug.LogError("Service does not exist in locator" + key);
            throw new InvalidOperationException();
        }

        return (T)_services[key];
    }
}
