using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftBox : MonoBehaviour
{
 
    Animator anim;
    GameObject Lift;
    bool Jump;

    private void Start  ()
    {
        
        anim = Lift.GetComponent<Animator>();
    

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {

            Jump = true;
            if(Jump==true)
            {
                anim.SetBool("Jump",true);
            }
        }
    }
    
}
    