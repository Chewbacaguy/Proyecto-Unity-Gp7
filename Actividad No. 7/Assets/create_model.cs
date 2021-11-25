using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]

public class create_model : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        CreateShape();
        UpdateMesh();
    }

    //Crear funcion de CreateShape
    void CreateShape()
    {
        //Crear el arreglo de vertices
        vertices = new Vector3[]
        {
            new Vector3 (0,0,0),
            new Vector3 (0,0,1),
            new Vector3 (1,0,0),
            new Vector3 (1,0,1),
            new Vector3 (0,1,0),
            new Vector3 (0,1,1),
            new Vector3 (1,1,0),
            new Vector3 (1,1,1)
        };
        //Crear el arreglo de enteros para los triángulos clockwise
        triangles=new int[]
        {
            0,1,2,
            1,3,2,
            0,4,5,
            5,1,0,
            4,5,6,
            5,7,6,
            2,6,7,
            7,3,2,
            0,4,6,
            6,2,0,
            1,5,7,
            7,3,1
        };
    }

    //Crear funcion de UpdateMesh
    void UpdateMesh () {
        mesh.Clear(); //Limpiar la información de la malla
        mesh.vertices=vertices; //Asignar los vértices de la malla al arreglo que creamos
        mesh.triangles=triangles; //Asignar la información de triángulos de la malla al arreglo que creamos
        Debug.DrawLine(Vector3.zero, new Vector3(10,0,0),Color.red);
        Debug.DrawLine(Vector3.zero, new Vector3(0,10,0),Color.green);
        Debug.DrawLine(Vector3.zero, new Vector3(0,0,10),Color.blue);
    }
}