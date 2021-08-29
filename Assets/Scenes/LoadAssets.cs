using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    public GameObject blueObj;
   
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(2.0f, 0.0f, 0.0f);
        //transform.rotation = new Vector3(0.0f, 0.0f, 0.0f);
        Instantiate(redObj, new Vector3(2.0f,0.0f,0.0f), Quaternion.identity);
        Instantiate(blueObj, new Vector3(-2.0f,0.0f,0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
