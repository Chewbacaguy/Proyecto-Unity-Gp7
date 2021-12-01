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
        public float spawnPointX;
        public float spawnPointZ;

    }

    [System.Serializable]
    public class VehicleList{

        public Vehicle[] Vehicle;

    }

    public VehicleList myVehicleList = new VehicleList();

    void PositionChange()
    {
        target = new Vector3(myVehicleList.Vehicle[step].spawnPointX, 1, myVehicleList.Vehicle[step].spawnPointZ);
    }

    // Start is called before the first frame update
    void Start()
    {

        myVehicleList = JsonUtility.FromJson<VehicleList>(jsonFile.text);
        PositionChange();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        step++;
        PositionChange();
        if(transform.position == target){

            Destroy(gameObject);

        }
        transform.position =  Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

 
    }

}
