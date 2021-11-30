using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JsonReader : MonoBehaviour
{
    List<List<Vector3>> positions;
    public GameObject agent1Prefab;
    public GameObject agent2Prefab;
    public GameObject agent3Prefab;
    public GameObject agent4Prefab;
    public GameObject agent5Prefab;
    //public string json;
    private string jsonString = Application.streamingAssetsPath + "Resources/results.json";



    void Start()
    {
        CreateFromJSON(jsonString);
    }

    public static Vehiculo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<Vehiculo>(jsonString);
    }


/*
    void Start()
    {
        int numOfAgents = 10;
        agents = new GameObject[numOfAgents];
        json = File.ReadAllText(Application.dataPath + "Resources/results.json");
        var data = JSON.Parse(json);
        //Vehiculos vehiculoEnJson = JsonUtility.FromJson<Vehiculos>(json_contents);


        for(int i = 0; i < numOfAgents; i++)
        {
            if (vehiculo.id == 1)
            {
                vehiculo = Instantiate(agent1Prefab, Vector3(vehiculo.coordX, 1, vehiculo.coordZ), Quaternion.identity);
            }
            else if (vehiculo.id == 2)
            {
                vehiculo = Instantiate(agent2Prefab, Vector3(vehiculo.coordX, 1, vehiculo.coordZ), Quaternion.identity);
            }
            else if (vehiculo.id == 3)
            {
                vehiculo = Instantiate(agent3Prefab, Vector3(vehiculo.coordX, 1, vehiculo.coordZ), Quaternion.identity);
            }
            else if (vehiculo.id == 4)
            {
                vehiculo = Instantiate(agent4Prefab, Vector3(vehiculo.coordX, 1, vehiculo.coordZ), Quaternion.identity);
            }
            else if (vehiculo.id == 5)
            {
                vehiculo = Instantiate(agent5Prefab, Vector3(vehiculo.coordX, 1, vehiculo.coordZ), Quaternion.identity);
            }


        }
      */

}


