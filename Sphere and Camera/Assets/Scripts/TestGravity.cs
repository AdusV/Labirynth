using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGravity : MonoBehaviour
{

    //public Collider coll;
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;
    void Start()
    {
       // coll = GetComponent<Collider>();
        //coll.isTrigger = true;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")//Tag to ma byc okiekt,ktory koliduje np. Kula jedzie na krawedz boxa to kula ma byc tagiem box moze byc untached
        {
            Physics.gravity = new Vector3(x, y, z);
        }
    }
}



