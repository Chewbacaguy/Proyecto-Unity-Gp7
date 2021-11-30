using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contagiar : MonoBehaviour
{
    public Transform PrefabContagiada;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(PrefabContagiada, transform.position, transform.rotation);
        Destroy(gameObject);
    }

  
}
