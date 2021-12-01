using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;



public class JsonReader : MonoBehaviour{

    public TextAsset jsonFile;
    public GameObject truck;
    public GameObject moto;
    public GameObject torus;
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
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
        for(int i = 0; i< 6; i++)
        {
            if(i == 0){
                
                Instantiate(truck, new Vector3(myVehicleList.Vehicle[i].coordX, 1, myVehicleList.Vehicle[i].coordZ), Quaternion.Euler(90, 180, 0));
            }

            else if(i == 1){
                Instantiate(moto, new Vector3(myVehicleList.Vehicle[i].coordX, 2, myVehicleList.Vehicle[i].coordZ), Quaternion.Euler(2, 180, 100));
            }

            else if(i == 2){
                Instantiate(torus, new Vector3(myVehicleList.Vehicle[i].coordX, 1, myVehicleList.Vehicle[i].coordZ), Quaternion.Euler(-90, 0, 0));
            }

            else if(i == 3){
                Instantiate(car1, new Vector3(myVehicleList.Vehicle[i].coordX, 1, myVehicleList.Vehicle[i].coordZ), Quaternion.Euler(270, 180, 90));
            }
            
            else if(i == 4){
                Instantiate(car2, new Vector3(myVehicleList.Vehicle[i].coordX, 1.5f, myVehicleList.Vehicle[i].coordZ), Quaternion.Euler(270, 210, 0));
            }

            else if(i == 5){
                Instantiate(car3, new Vector3(myVehicleList.Vehicle[i].coordX, 1.5f, myVehicleList.Vehicle[i].coordZ), Quaternion.Euler(270, 210, 0));
            }

        }

    }


    void Update()
    {
        /*
        for (int i = 0; i < 4; i++)
        {
            transform.position = Vector3.MoveTowards(transform.position, endpoint, speed * Time.deltaTime);
           

        }*/
    }


}


