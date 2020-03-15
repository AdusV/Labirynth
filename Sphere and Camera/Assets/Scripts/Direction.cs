using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    public bool upDirection = true;
    private void OnTriggerStay(Collider other)
    {
        GameObject thing = other.gameObject;
        Rigidbody rigidbody = thing.GetComponent<Rigidbody>();
        Vector3 velocity = rigidbody.velocity;

        if(upDirection)
        {
            velocity.y = 50f;
        }
       /* else
        {
            velocity.x = -5f;
        }*/
        rigidbody.velocity = velocity;
    }
}
