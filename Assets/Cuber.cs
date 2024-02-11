using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuber : MonoBehaviour
{
    bool spinning = false;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!spinning)
            {
                animator.SetBool("spin", true);
                spinning = true;
            }
            else
            {
                animator.SetBool("spin", false);
                spinning = false;
            }
        }
    }
}
