using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;



public class JsonReader : MonoBehaviour{

    public TextAsset jsonFile;
    public GameObject prefab;

    [System.Serializable]
    public class Vehicle{

        public int id;
        public double spawnPointX;
        public double spawnPointZ;

    }

    [System.Serializable]
    public class VehicleList{

        public Vehicle[] Vehicle;

    }

    public VehicleList myVehicleList = new VehicleList();


    void Start()
    {
        
        myVehicleList = JsonUtility.FromJson<VehicleList>(jsonFile.text);

        double coordX = myVehicleList[0];
        double coordZ = myVehicleList[0].spawnPointZ;

        Instantiate(prefab, Vector3(coordX, 1, coordZ), Quaternion.identity);

    }

}


