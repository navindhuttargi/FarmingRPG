using UnityEngine;

public class SingletonMonobehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instace;
    public static T Instance
    {
        get => instace;
    }
    protected virtual void Awake()
    {
        if (instace == null)
            instace = this as T;
        else
            Destroy(gameObject);
    }
}
