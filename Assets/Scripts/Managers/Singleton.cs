using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    
    protected static T _instance;

    public static T Instance
    {
        get
        {
            if(_instance == null)
            {   
                _instance = (T)FindObjectOfType<T>();
                
                if(_instance == null)
                {
                    GameObject obj = new GameObject(typeof(T).ToString());
                    obj.AddComponent<T>();
                }
            }
            return _instance;
        }
    }
        
}
