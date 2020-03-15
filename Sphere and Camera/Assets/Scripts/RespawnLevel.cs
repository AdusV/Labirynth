using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnLevel : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject wallPrefab;
   /* public GameObject wall1Prefab;
    public GameObject wall2Prefab;
    public GameObject wall3Prefab;*/
    Vector3 xTurn = new Vector3(-10, 0, 10);
    Vector3 xNew = new Vector3(10, 0, 10);
    Vector3 zTurn = new Vector3(-10, 0, 0);
    
    private void Start()
    {
        GameObject wall = GameObject.Instantiate(wallPrefab);
        wall.transform.localEulerAngles = new Vector3(0,90,0);
        /*GameObject.Instantiate(boxPrefab);
        GameObject.Instantiate(wallPrefab);
        GameObject.Instantiate(wall2Prefab);
        GameObject wall3 = GameObject.Instantiate(wall2Prefab);
        wall3.transform.position = transform.position + zTurn;
        GameObject wall2 = GameObject.Instantiate(wall2Prefab);
        wall2.transform.position = transform.position + xNew;*/
       

    }
}
