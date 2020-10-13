using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class trocacena : MonoBehaviour
{
    public bool cena = false;
    void Start()
    { 
        if(cena == false)
        {
            cena = true;
            Invoke("GotoNextScene", 21f);
        }
       
    }  
    void GotoNextScene()
    {
        SceneManager.LoadScene("level1");
    }

}
