using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectControllerP1 : MonoBehaviour
{
    public GameObject[] p1characters;
    public GameObject[] characterSelect;

    public int p1index;
    public bool p1selected;

    [SerializeField] bool p1keyDown;
    [SerializeField] int maxIndex;

    void Update()
    {
        P1SelectCharacter();
        ChangeP1Character(p1index);

        Vector3 p1pos = characterSelect[p1index].transform.localPosition;
        transform.localPosition = p1pos;
    }

    public void P1SelectCharacter()
    {
        if (Input.GetAxis("Horizontal") != 0 && !p1selected)
        {
            if (!p1keyDown)
            {
                if (Input.GetAxis("Horizontal") > 0)
                {
                    if (p1index < maxIndex)
                    {
                        p1index++;
                    }
                    else
                    {
                        p1index = 0;
                    }
                }

                else if (Input.GetAxis("Horizontal") < 0)
                {
                    if (p1index > 0)
                    {
                        p1index--;
                    }
                    else
                    {
                        p1index = maxIndex;
                    }
                }
                p1keyDown = true;
            }

        }
        else
        {
            p1keyDown = false;
        }
    }


    public void ChangeP1Character(int index)
    {
        for (int i = 0; i < p1characters.Length; i++)
        {
            p1characters[i].SetActive(false);
        }

        p1characters[index].SetActive(true);
    }
}
