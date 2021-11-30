using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JsonReader : MonoBehaviour
{
    public TextAsset jsonFile;

    //Si tienes una carpeta "StreamingAssets" dentro de la carpeta Assets de tu proyecto, 
    //esta será copiada a los archivos instalados del player y estará presente en la ruta dada por Application.streamingAssetsPath.
    string path_to_json = Application.streamingAssetsPath + "/results.json";
    string json_contents = File.ReadAllText(path_to_json);


    void Start()
    {
        Vehiculos vehiculoEnJson = JsonUtility.FromJson<Vehiculos>(jsonFile.text);

        foreach(Vehiculo vehiculo in vehiculoEnJson.vehiculos)
        {
            Debug.Log("tengo vehiculo con id " + vehiculo.id + "en pos " + vehiculo.spawnPointX + "," + vehiculo.spawnPointZ);
        }
    }
}


