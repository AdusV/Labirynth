using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrollController : MonoBehaviour
{
    public float scrollSpeed = 15;
    public float zoomSpeed = 25;
    public float rotationSpeed = 15;
    public float scrollKeyboardSpeed = 15;
    [Header("Limits")]
    public float minZoom = 40;
    public float maxZoom = 20;
    public Vector2 minPosition = new Vector2(0, 0);
    public Vector2 maxPosition = new Vector2(400, 400);

    private GameObject contener;
    private float scrollSpeedUp = 0;

    private void Start()
    {
        contener = gameObject.transform.parent.gameObject;
        if ((Input.mousePosition.y >= Screen.height * 0.95 || Input.GetKey(KeyCode.Alpha8))&& contener.transform.position.z < maxPosition.y)
            {
            contener.transform.Translate(Vector3.forward * Time.deltaTime * (scrollSpeed * scrollSpeedUp));
            }
        if ((Input.mousePosition.y <= Screen.height * 0.05 || Input.GetKey(KeyCode.Alpha2)) && contener.transform.position.z > minPosition.y)
        {
            contener.transform.Translate(Vector3.back * Time.deltaTime * (scrollSpeed + scrollSpeedUp));
        }

        if ((Input.mousePosition.x <= Screen.width * 0.05 || Input.GetKey(KeyCode.Alpha4)) && contener.transform.position.x > minPosition.x)
        {
            contener.transform.Translate(Vector3.left * Time.deltaTime * (scrollSpeed + scrollSpeedUp));
        }

        if ((Input.mousePosition.x >= Screen.width * 0.95 || Input.GetKey(KeyCode.Alpha6)) && contener.transform.position.x < maxPosition.x)
        {
            contener.transform.Translate(Vector3.right * Time.deltaTime * (scrollSpeed + scrollSpeedUp));
        }
  
        if ((Input.mouseScrollDelta.y / 10) > 0 && gameObject.transform.position.y > maxZoom)
        {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * zoomSpeed);
        }
        if ((Input.mouseScrollDelta.y / 10) < 0 && gameObject.transform.position.y < minZoom)
        {
            gameObject.transform.Translate(Vector3.back * Time.deltaTime * zoomSpeed);
        }
        

        if (Input.GetMouseButton(2))
        {

            // Obrót po naciśnięciu kółka
            if (Input.mousePosition.x <= Screen.width * 0.05 || Input.GetKey(KeyCode.LeftArrow))
            {
                contener.transform.Rotate(Vector3.down * Time.deltaTime * rotationSpeed);
            }

            if (Input.mousePosition.x >= Screen.width * 0.95 || Input.GetKey(KeyCode.RightArrow))
            {
                contener.transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
            }
        }
        else
        {
            if ((Input.mousePosition.y >= Screen.height * 0.95 || Input.GetKey(KeyCode.Alpha8)) && contener.transform.position.z < maxPosition.y)
            {
                contener.transform.Translate(Vector3.forward * Time.deltaTime * (scrollSpeed * scrollSpeedUp));
            }
            if ((Input.mousePosition.y <= Screen.height * 0.05 || Input.GetKey(KeyCode.Alpha2)) && contener.transform.position.z > minPosition.y)
            {
                contener.transform.Translate(Vector3.back * Time.deltaTime * (scrollSpeed + scrollSpeedUp));
            }

            if ((Input.mousePosition.x <= Screen.width * 0.05 || Input.GetKey(KeyCode.Alpha4)) && contener.transform.position.x > minPosition.x)
            {
                contener.transform.Translate(Vector3.left * Time.deltaTime * (scrollSpeed + scrollSpeedUp));
            }

            if ((Input.mousePosition.x >= Screen.width * 0.95 || Input.GetKey(KeyCode.Alpha6)) && contener.transform.position.x < maxPosition.x)
            {
                contener.transform.Translate(Vector3.right * Time.deltaTime * (scrollSpeed + scrollSpeedUp));
            }
        }
    }

}
