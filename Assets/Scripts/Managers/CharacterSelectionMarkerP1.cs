using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionMarkerP1 : MonoBehaviour
{
    [SerializeField] CharacterSelectControllerP1 characterControllerP1;
    [SerializeField] Animator animator;
    [SerializeField] int thisIndex;

    public bool playerTrigger;

    void Update()
    {
        P1AnimatorControll();
    }

    void P1AnimatorControll()
    {
        if (characterControllerP1.p1index == thisIndex && !playerTrigger )
        {
            animator.SetBool("selected", true);
            if (Input.GetAxis("Submit") == 1)
            {
                animator.SetBool("pressed", true);
                characterControllerP1.p1selected = true;
            }
            else if (Input.GetAxis("Cancel") == 1)
            {
                animator.SetBool("pressed", false);
                characterControllerP1.p1selected = false;
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
