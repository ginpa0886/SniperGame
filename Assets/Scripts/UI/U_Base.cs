using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_PageStage
{
    MainPage,
    SelectPage,
    GamePage,

    Last
}

public abstract class U_Base : MonoBehaviour
{
    public E_PageStage e_pageType;

    public abstract void OnInit();

    public abstract void OnExit();

}
