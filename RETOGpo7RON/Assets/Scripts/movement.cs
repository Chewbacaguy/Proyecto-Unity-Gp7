using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public int step = 0;
    private float t;
    public float speed = 0.5f;
    public TextAsset jsonFile;
    public Transform prefab;
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

    void PositionChange()
    {
      
        target = new Vector3(myVehicleList.Vehicle[0].coordX, 1, myVehicleList.Vehicle[0].coordZ);
    }

  /*  void Stop()
    {

        target = new Vector3(myVehicleList.Vehicle[0].nextPX, 1, myVehicleList.Vehicle[0].nextPZ);
    }*/

    // Start is called before the first frame update
    void Start()
    {

        myVehicleList = JsonUtility.FromJson<VehicleList>(jsonFile.text);
        //PositionChange();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        //PositionChange();
        if(transform.position == target){

            Destroy(gameObject);

        }
/*
        endpoint = new Vector3(myVehicleList.Vehicle[0].endPX, 1, myVehicleList.Vehicle[0].endPZ);
        transform.position = Vector3.MoveTowards(transform.position, endpoint, speed * Time.deltaTime);
*/

    }

}
