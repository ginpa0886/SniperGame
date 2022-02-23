using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WindowManager : Singleton<WindowManager>
{
    [HideInInspector] public GameObject u_Page;
    [HideInInspector] public U_Base[] u_PageObj;

    U_Base u_curPageObj;

    void Start()
    {
        u_PageObj = u_Page.transform.GetComponentsInChildren<U_Base>();
    }

    public void Set_PageState(E_PageStage page)
    {
        if (u_curPageObj == null)
        {
            for (int i = 0; i < (int)E_PageStage.Last; i++)
            {
                if (i == (int)page)
                    u_curPageObj = u_PageObj[i];
            }
        }
        else
            u_curPageObj.OnExit();


        for(int i = 0; i < (int)E_PageStage.Last; i++)
        {
            if (i == (int)page)
            {
                u_PageObj[i].gameObject.SetActive(true);
                u_curPageObj = u_PageObj[i];
            }                
            else
                u_PageObj[i].gameObject.SetActive(false);
        }

        u_curPageObj.OnInit();
    }
}
