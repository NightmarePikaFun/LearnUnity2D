using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    private string name = "WalkSide";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if(y!=0)
        {
            if (y > 0)
                animator.SetInteger(name, 1);
            else
                animator.SetInteger(name, 3);
        }
        else if(x!=0)
        {
            if (x > 0)
                animator.SetInteger(name, 2);
            else
                animator.SetInteger(name, 4);
        }
        else
        {
            animator.SetInteger(name,0);
        }
    }
}
