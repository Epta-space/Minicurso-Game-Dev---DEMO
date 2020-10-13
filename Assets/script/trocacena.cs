using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class trocacena : MonoBehaviour
{
    void Start()
    {
            InvokeRepeating("GotoNextScene", 19f,100000f);
    }  
    void GotoNextScene()
    {
        SceneManager.LoadScene("level1");
    }

}
