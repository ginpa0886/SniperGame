using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionMarkerP2 : MonoBehaviour
{
    [SerializeField] CharacterSelectControllerP2 characterControllerP2;
    [SerializeField] Animator animator;
    [SerializeField] int thisIndex;

    public bool playerTrigger;

    void Update()
    {
        P2AnimatorControll();
    }

    void P2AnimatorControll()
    {
        if (characterControllerP2.p1index == thisIndex && !playerTrigger)
        {
            animator.SetBool("selected", true);
            if (Input.GetAxis("P2Submit") == 1)
            {
                animator.SetBool("pressed", true);
                characterControllerP2.p1selected = true;
            }
            else if (Input.GetAxis("P2Cancel") == 1)
            {
                animator.SetBool("pressed", false);
                characterControllerP2.p1selected = false;
            }
        }

        else
        {
            animator.SetBool("selected", false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerTrigger = false;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerTrigger = true;
        }
    }
}
