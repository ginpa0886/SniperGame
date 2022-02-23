using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // T라는 타입에 스크립트 마다 유일한 인스턴스를 생성해야 하므로 protected를 사용합니다
    protected static T _instance;

    public static T Instance
    {
        get
        {
            // 생성한 인스턴스가 할당되어 있지 않다면
            if(_instance == null)
            {
                // 해당 타입을 찾아서 넣어줍니다
                _instance = (T)FindObjectOfType<T>();

                // 해당 Scene안에 타입이 없다면 새로 하나 생성해서 할당해줍니다
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
