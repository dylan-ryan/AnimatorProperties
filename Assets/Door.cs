using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator doorAnimator;
    bool open = false;

    // Start is called before the first frame update
    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!open)
            {
                doorAnimator.SetBool("opening", true);
                doorAnimator.SetBool("closing", false);
                open = true;
            }
            else
            {
                doorAnimator.SetBool("opening", false);
                doorAnimator.SetBool("closing", true);
                open = false;
            }
        }
    }
}