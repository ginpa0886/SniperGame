using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class U_Main : U_Base
{
    public Button u_Btn;

    public override void OnInit()
    {
        Debug.Log("Main Page init");
    }

    public override void OnExit()
    {
        Debug.Log("Main Page Exit");
    }

    public void Set_SelectPage()
    {
        WindowManager.Instance.Set_PageState(E_PageStage.SelectPage);
    }
}
