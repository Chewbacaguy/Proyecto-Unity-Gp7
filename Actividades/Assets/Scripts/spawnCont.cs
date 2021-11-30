using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCont : MonoBehaviour
{
    public GameObject prefabContagiada;
    public int cont = 4;
    List<GameObject> Contagiados;

    // Start is called before the first frame update
    void Start()
    {
        Contagiados = new List<GameObject>();
        for (int i = 0; i < cont; i++)
        {
            float x = Random.Range(-31, 31);
            float y = 0;
            float z = Random.Range(-26, 26);

            Contagiados.Add(Instantiate(prefabContagiada, new Vector3(x, y, z), Quaternion.Euler(0, 0, 0)));
        }
    }
}
