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
        public float spawnPointX;
        public float spawnPointZ;

    }

    [System.Serializable]
    public class VehicleList{

        public Vehicle[] Vehicle;

    }

    public VehicleList myVehicleList = new VehicleList();



    void Start()
    {
        
        myVehicleList = JsonUtility.FromJson<VehicleList>(jsonFile.text);
        spawnPoint = new Vector3(myVehicleList.Vehicle[0].spawnPointX, 1, myVehicleList.Vehicle[0].spawnPointZ);
        Instantiate(prefab, spawnPoint, Quaternion.Euler(90, 180, 0));



    }

    void Update(){


    }

}


