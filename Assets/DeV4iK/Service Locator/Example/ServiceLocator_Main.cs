using UnityEngine;

public class ServiceLocator_Main : MonoBehaviour
{
    private void Awake()
    {
        ServiceLocator.Initialize();

        ILoader loader = new JsonLoader();
        ServiceLocator.Current.Register(loader);
    }
}
