using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCamer : MonoBehaviour
{
    public Light slonce;
    bool wSlonce = false;


    

    private void Update()
    {
        //Wlaczanie swiatla
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (!wSlonce)
            {
                slonce.enabled = false;
                wSlonce = true;
            }
            else
            {
                slonce.enabled = true;
                wSlonce = false;
            }
          
            

        }




    }
}


