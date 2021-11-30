using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementSick : MonoBehaviour
{
    public float vel = 0.3f;
    Vector3 target;
 

    void Start()
    {
        move();
    }

    void move()
    {
        target = new Vector3(Random.Range(-33, 33), 0 , Random.Range(-26, 30));
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
            move();

        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * vel);


    }




}