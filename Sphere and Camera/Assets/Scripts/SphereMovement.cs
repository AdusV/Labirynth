using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SphereMovement : MonoBehaviour
{
    public float playerWalkingSpeed = 5f;
    public float playerRunningSpeed = 15f;
    public float jumpStrenght = 4f;
    CharacterController cc;
    float verticalVelocity;
    float verticalRotation = 0f;
    float verticalRotationLimit = 1f;
    float forwardMovement;
    float sidewaysMovement;
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        //Rozglądanie na boki
       /* float horizontalRotation = Input.GetAxis("Mouse X");
        transform.Rotate(0, horizontalRotation, 0);

        //Rozglądanie się góra dół
        verticalRotation = Input.GetAxis("Mouse Y");
        verticalRotation = Mathf.Clamp(verticalRotation, -verticalRotation, verticalRotationLimit);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        */
        //Poruszanie 
        if (cc.isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                forwardMovement = Input.GetAxis("Vertical") * playerRunningSpeed;
                sidewaysMovement = Input.GetAxis("Horizontal") * playerRunningSpeed;
            }
            {
                verticalVelocity += Physics.gravity.y * Time.deltaTime;

                if (Input.GetKey(KeyCode.Space) )
                {
                    verticalVelocity = jumpStrenght;
                }
                Vector3 playerMovement = new Vector3(sidewaysMovement, verticalVelocity, forwardMovement);
                cc.Move(transform.rotation * playerMovement * Time.deltaTime);
            }
        }
    }
}
