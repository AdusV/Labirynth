using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    //Kamery
    public bool PrzelacznikKamer = true;
    public Camera[] Kamery;
    public int NumerKamery = -1;
    
    private void Start()
    {
        Kamery[0].enabled = true;
        Kamery[1].enabled = false;
    }
  
 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (PrzelacznikKamer)
            {
                NumerKamery++;

                switch (NumerKamery)
                {
                    case 0:
                        {
                            Debug.Log("Kamera 1");
                            Kamery[0].enabled = false;
                            Kamery[1].enabled = true;                          
                            NumerKamery = 0;
                            
                        };
                        break;
                    case 1:
                        {
                            Debug.Log("Kamera 2");
                            
                            Kamery[0].enabled = true;
                            Kamery[1].enabled = false;



                        }; 
                        break;
                    default:
                        {
                            Debug.Log("Kamera 1");
                            Kamery[0].enabled = false;
                            Kamery[1].enabled = true;
                            NumerKamery = 0;
                        }
                        break;


                }

            }
        }
    }

}
