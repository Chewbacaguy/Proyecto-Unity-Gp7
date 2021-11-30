/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using SimpleJSON;

public class JSONController : MonoBehaviour
{
    public GameObject obj;
    Vector3 buttonPos;
    private string url = Application.streamingAssetsPath + "Resources/results.json";
    string xcoor;
    string ycoor;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(getData());

    }

    IEnumerator getData()
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.LogError(request.error);
            yield break;
        }
        JSONNode coordinates = JSON.Parse(request.downloadHandler.text);
        xcoor = coordinates["x1"];
        ycoor = coordinates["y1"];
        //Debug.Log(xcoor);


    }

    // Update is called once per frame
    void Update()
    {
        buttonPos = new Vector3(xcoor, ycoor, 4f);
        if (Input.GetButton("Fire1"))
            Instantiate(obj, buttonPos, Quaternion.identity);
    }
}*/