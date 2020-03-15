using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public GameObject particles;
    private void OnTriggerEnter(Collider other)
    {
        
            if (other.gameObject.tag == "Crystal")
            {
            return;
            }
            Debug.Log("Touch me");
            if (leaveCrystals() == 1)
            {
                Application.LoadLevel("Level 2");
            }
            else
            {
            Instantiate(particles,   transform.position, Quaternion.identity);
            Debug.Log("haha");
            Destroy(this.gameObject);
        }

    }

    int leaveCrystals()
    {
        Crystal[]crystals=Component.FindObjectsOfType<Crystal>();
        return crystals.Length;
    }
}
