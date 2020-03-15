using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float playerWalkingSpeed = 5f;
    public float playerRunningSpeed = 15f;
    public float jumpStrength = 5f;
    //Blokada obrotu osi Y
    public float verticalRotationLimit = 80f;

    float forwardMovement;
    float sidewaysMovement;

    float verticalRotation = 0;

    float verticalVelocity;

    CharacterController cc;
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        //Rozgladanie sie na boki
        float horizontalRotation = Input.GetAxis("Mouse X");
        transform.Rotate(0, horizontalRotation, 0);

        //Rozgladanie sie gora, dol
        //Mathf.Clamp - ograniczenie wartosci miedzy min a max
         verticalRotation -= Input.GetAxis("Mouse Y");
        verticalRotation = Mathf.Clamp(verticalRotation, -verticalRotationLimit, verticalRotationLimit);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        //Poruszanie graczem
        forwardMovement = Input.GetAxis("Vertical") * playerWalkingSpeed;
        sidewaysMovement = Input.GetAxis("Horizontal") * playerWalkingSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            forwardMovement = Input.GetAxis("Vertical") * playerRunningSpeed;
            sidewaysMovement = Input.GetAxis("Horizontal") * playerRunningSpeed;
        }
        verticalVelocity += Physics.gravity.y * Time.deltaTime;
        //if (Input.GetButton("Jump")&&cc.isGrounded) Jesli chce , zeby nie bylo podwojnego skoku
        if (Input.GetButton("Jump"))
        {
            verticalVelocity = jumpStrength;
        }
        Vector3 playerMovement = new Vector3(sidewaysMovement, verticalVelocity, forwardMovement);

     

        cc.Move(transform.rotation * playerMovement * Time.deltaTime);
    }
}
