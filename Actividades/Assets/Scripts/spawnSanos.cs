using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSanos : MonoBehaviour
{
    public GameObject prefabSano;
    public int cont = 20;
    List<GameObject> noContagiados;

    // Start is called before the first frame update
    void Start()
    {
        noContagiados = new List<GameObject>();
        for(int i = 0; i<cont; i++)
        {
            float x = Random.Range(-31, 22);
            float y = 0;
            float z = Random.Range(-26, 26);

            noContagiados.Add(Instantiate(prefabSano, new Vector3(x, y, z), Quaternion.Euler(0,0,0)));
        }
    }




  
}
