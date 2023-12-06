using System;
using System.Collections.Generic;
using UnityEngine;

public static class ServiceLocator
{
    private static readonly Dictionary<string, IService> _services = new Dictionary<string, IService>();

    public static bool RegisterService<T>(T service) where T : IService
    {
        string key = typeof(T).Name;
        if (_services.ContainsKey(key))
            return false;

        _services.Add(key, service);
        return true;
    }

    public static bool UnregisterService<T>() where T : IService
    {
        string key = typeof(T).Name;
        if(!_services.ContainsKey(key))
            return false;

        _services.Remove(key);
        return true;
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
