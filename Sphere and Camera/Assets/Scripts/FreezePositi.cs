using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePositi : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_ZAxis;
    Animator anim;
    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
        m_ZAxis = new Vector3(0, 3, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
       
        Debug.Log("Akcja");
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);

        }
    }
}
