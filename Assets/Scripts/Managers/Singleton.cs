using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // T��� Ÿ�Կ� ��ũ��Ʈ ���� ������ �ν��Ͻ��� �����ؾ� �ϹǷ� protected�� ����մϴ�
    protected static T _instance;

    public static T Instance
    {
        get
        {
            // ������ �ν��Ͻ��� �Ҵ�Ǿ� ���� �ʴٸ�
            if(_instance == null)
            {
                // �ش� Ÿ���� ã�Ƽ� �־��ݴϴ�
                _instance = (T)FindObjectOfType<T>();

                // �ش� Scene�ȿ� Ÿ���� ���ٸ� ���� �ϳ� �����ؼ� �Ҵ����ݴϴ�
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
