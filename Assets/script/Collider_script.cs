﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collider_script : MonoBehaviour
{
    public int count;
    public GameObject teste;

    public GameObject controlls;


    void start(){
        count = 0;
        // controlls = GameObject.FindGameObjectWithTag("canvas_controles");
    }

    void OnCollisionEnter2D(Collision2D col){

        if (col.gameObject.CompareTag("perigo"))
        {
            print("Você perdeu!!");
            FindObjectOfType<gameManager>().GameOver();
        }

        if (col.gameObject.CompareTag("Collectable")) //If thing hit is tagged "Obstacle"
        {
            Destroy(col.gameObject); //Then destroy the player
            count ++;
            print(count);
        }
        else if(col.gameObject.CompareTag("Launch_base")) //If thing hit is tagged "Obstacle"
        {
            if(count ==  4){
                print("Você venceu!!");
                SceneManager.LoadScene("CutScene2");
            } 
            else{

                controlls.SetActive(true);
                Time.timeScale = 0;
                print("Colete os objetos faltantes");
            }
        }
    }
}

