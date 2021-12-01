using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    public static bool state = true;
    private float time = 0f;
    public float timer = 10f;

    void Start ()
    {

    }

    void stateChange()
    {
        if(state == true)
        {
            state = false;
        }
        else
        {
            state = true;
        }
    }

    void Update()
    {
        if(state == true){
            myMaterial.color = Color.green;
        }
        else{
            myMaterial.color = Color.red;
        }
        if(time/24 == timer)
        {
            stateChange();
            time = 0;
        }
        time++;
    }
}