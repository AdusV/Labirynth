using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {//tag, ktory uderza musi byc podpisany
        if(other.gameObject.tag == "kula")
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}
