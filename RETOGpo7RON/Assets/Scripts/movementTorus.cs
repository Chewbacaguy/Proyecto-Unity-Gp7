using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementTorus : MonoBehaviour
{
    public int step = 0;
    private float t;
    public float speed = 0.5f;
    public TextAsset jsonFile;
    public Transform prefab;
    public Vector3 endpoint;
    public Vector3 stop;
    public Vector3 target;

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
/*
    void PositionChange()
    {
      
        target = new Vector3(myVehicleList.Vehicle[0].coordX, 1, myVehicleList.Vehicle[0].coordZ);
    }*/

    void Start()
    {

        myVehicleList = JsonUtility.FromJson<VehicleList>(jsonFile.text);
        //PositionChange();
        
    }

    // Update is called once per frame
    void Update()
    {
        stop = new Vector3(myVehicleList.Vehicle[2].nextPX, 1, myVehicleList.Vehicle[2].nextPZ);
        endpoint = new Vector3(myVehicleList.Vehicle[2].endPX, 1, myVehicleList.Vehicle[2].endPZ);
        
        if((transform.position[0] + 5 > stop[0]) && ChangeColor.state == false){

            target = stop;

        }

        else{

            target = endpoint;

        }
        //PositionChange();
        if(transform.position == endpoint){

            Instantiate(gameObject, new Vector3(myVehicleList.Vehicle[2].coordX, 1, myVehicleList.Vehicle[2].coordZ), Quaternion.Euler(-90, 0, 0));
            Destroy(gameObject);

        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);


    }
}
