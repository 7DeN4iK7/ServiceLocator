using System;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator
{
    private ServiceLocator()
    {

    }

    private readonly Dictionary<string, IService> _services = new();

    public static ServiceLocator Current { get; private set; }

    public static void Initialize()
    {
        Current = new ServiceLocator();
    }

    public void Register<T>(T service) where T : IService
    {
        string key = typeof(T).Name;
        if(_services.ContainsKey(key))
        {
            Debug.LogError($"Attempted to register already registered service: {key}");
            return;
        }

        _services.Add(key, service);
    }

    public void Unregister<T>(T service) where T : IService
    {
        string key = typeof(T).Name;
        if(!_services.ContainsKey(key))
        {
            Debug.Log($"Attempted to unregister non existing service: {key}");
            return;
        }

        _services.Remove(key);
    }

    public T Get<T>() where T : IService
    {
        string key = typeof(T).Name;
        if(!_services.ContainsKey(key))
        {
            Debug.LogError($"{key} is not registered!");
            throw new InvalidOperationException();
        }

        return (T)_services[key];
    }
}
