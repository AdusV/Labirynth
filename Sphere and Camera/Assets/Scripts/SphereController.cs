using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    // Jazda luli po skosie "=" na "+=" 
    public float direction = 5f;
    //Warstwy
    int layer = 0;
    //Fizyka
    new Rigidbody  rigidbody;
    

    private void Start()
    {
          
        rigidbody = transform.GetComponent<Rigidbody>();
    }
    void Update()
    {     
    
        //changeLayer();
        changePosition();
         
    }
    //Tworzenie warstwy dla ruchu kuli zmiana polozenia kamery. Problem polega na stworzeniu planszy, która dziala na zasadzie prawo, lewo,gora , dol. Plansza ma byc kula, ktora z ruchem sie obraca   
    void changeLayer()
    {
        //GetKeyDown odczytuje, czy klawisz zostal wcisnety dluzsze przytrzzymywanie nic nie da

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Rysowanie lini
           // Debug.DrawRay(transform.position, Vector3.forward * 2f, Color.red);
            //Czy napotykamy przeszkode
            //bool isSomething = Physics.Raycast(transform.position, Vector3.forward, 2f);

            /*if(!isSomething)
            {
                layer = 0;  
            }*/
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           // Debug.DrawRay(transform.position, Vector3.back * 2f, Color.blue);
            //bool isSomething = Physics.Raycast(transform.position, Vector3.forward, 2f);

            /*if (!isSomething)
            {
                layer = 1;
            }*/
        }
        
        float delta = (layer * 2f - 2f) - rigidbody.position.z;
            
        Vector3 velocity = rigidbody.velocity;
        velocity.z = delta * 3f;
        rigidbody.velocity = velocity;
    }
    void changePosition()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
           // Debug.DrawRay(transform.position, Vector3.forward * 2f, Color.red);
            direction = Vector3.right;
            Debug.Log("Do góry");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Debug.DrawRay(transform.position, Vector3.back * 2f, Color.blue);
            direction = Vector3.left;
            Debug.Log("Na dół");
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           
            direction = Vector3.forward;
            Debug.Log("W lewo");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = -Vector3.forward;
            Debug.Log("W prawo");
        }
        rigidbody.AddTorque(direction);
    }
 
}
