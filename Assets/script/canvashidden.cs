using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvashidden : MonoBehaviour
{
    public GameObject controlls;

    // Start is called before the first frame update
    public void close_this(){
        controlls.SetActive(false);
        Time.timeScale = 1;
    }
}
