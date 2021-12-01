using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;



public class JsonReader : MonoBehaviour{

    public TextAsset jsonFile;
    public GameObject prefab;
    public Vector3 spawnPoint;

    [System.Serializable]
    public class Vehicle{

        public int id;
        public float coordX;
        public float coordZ;
        public float nextPX;
        public float nextPZ;
        public float endPX;
        public float endPZ;

    }

    [System.Serializable]
    public class VehicleList{

        public Vehicle[] Vehicle;

    }

    public VehicleList myVehicleList = new VehicleList();



    void Start()
    {
        
        myVehicleList = JsonUtility.FromJson<VehicleList>(jsonFile.text);
        for(int i = 0; i< 4; i++)
        {
            Instantiate(prefab, new Vector3(myVehicleList.Vehicle[i].coordX, 1, myVehicleList.Vehicle[i].coordZ), Quaternion.Euler(90, 180, 0));


        }

    }


    void Update()
    {
        
        for (int i = 0; i < 4; i++)
        {
            transform.position = Vector3.MoveTowards(transform.position, endpoint, speed * Time.deltaTime);
           

        }
    }


}


