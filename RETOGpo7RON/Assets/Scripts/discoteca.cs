using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discoteca : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    public int state = 0;
    private float time = 0f;
    public float timer = 10f;

    void Start ()
    {

    }

    void stateChange()
    {
        myMaterial.color = Color.red;
    }

    void Update()
    {

        
        if(time/6 == timer)
        {
            time = 0;
            state = Random.Range(0, 6);
        }

        if(state == 0){
            myMaterial.color = Color.blue;
        }
        if(state == 1){
            myMaterial.color = Color.red;
        }
        if(state == 2){
            myMaterial.color = Color.yellow;
        }
        if(state == 3){
            myMaterial.color = Color.green;
        }
        if(state == 4){
            myMaterial.color = Color.black;
        }
        if(state == 5){
            myMaterial.color = Color.white;
        }
        if(state == 6){
            myMaterial.color = Color.cyan;
        }
        time++;
    }
}
