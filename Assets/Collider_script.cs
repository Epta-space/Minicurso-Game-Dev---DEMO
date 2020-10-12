using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_script : MonoBehaviour
{
    public int count;

    void start(){
        count = 0;
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Collectable")) //If thing hit is tagged "Obstacle"
        {
            Destroy(col.gameObject); //Then destroy the player
            count ++;
            print(count);
        }
        else if(col.gameObject.CompareTag("Launch_base")) //If thing hit is tagged "Obstacle"
        {
            if(count ==  4){
                print("Você venceu!!");
            } else{
                print("Colete os objetos faltantes");
            }
        }
    }
}

