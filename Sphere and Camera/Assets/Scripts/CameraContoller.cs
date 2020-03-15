using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    public Transform sphere;
    public float speed = 5f;
    //  
  


    void Start()
    {
   
    }

  
    void Update()
    {
        Rigidbody rigidbody = sphere.GetComponent<Rigidbody>();

        Vector3 vector = new Vector3(0, 2f, -8f); //pozycja kamery   
        float velocity = rigidbody.velocity.sqrMagnitude;
        vector = vector * (1f+velocity/100);

        Vector3 newPosition = sphere.position + vector;
        //Aktualan pozycja,Nowa pozycja, Szybkosc z jaka sie przenosi kamera    
        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime*speed);
        transform.LookAt(sphere);//Gdzie kamera ma patrzec jaki punkt
                                 //
       

    }
}
