using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    void Start()
    {
        StartCoroutine(Co_Start());   
    }

    IEnumerator Co_Start()
    {
        yield return null;
        WindowManager.Instance.Set_PageState(E_PageStage.MainPage);
    }




}
