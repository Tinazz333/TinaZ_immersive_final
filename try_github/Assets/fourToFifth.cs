using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fourToFifth : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        SceneManager.LoadScene(4);
    }
        
}
