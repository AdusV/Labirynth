using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject ballPrefab;
    public Camera cameraPrefab;
    public Light lightPrefab;

    public GameObject gameOverBase;
    public GameObject levelName;

    private void Start()
    {
        GameObject sphere = GameObject.Instantiate(ballPrefab);
        sphere.name = "sphere";
        sphere.transform.position = transform.position + Vector3.up * 5f;

        Camera camera = GameObject.Instantiate(cameraPrefab);
        CameraContoller cameraContoller = camera.GetComponent<CameraContoller>();
        cameraContoller.sphere = sphere.transform;

        Light light = GameObject.Instantiate(lightPrefab);
        light.color = Color.white;
        light.intensity = 0.5f;
        RenderSettings.ambientLight = Color.white * 0.7f;

        GameObject.Instantiate(gameOverBase);
        GameObject.Instantiate(levelName);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
