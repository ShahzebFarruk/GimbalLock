using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eulrotation : MonoBehaviour 
{
    public Vector3 eulerrot;
    public Vector3 rotationAngles;

    void Start () 
    {
         eulerrot = new Vector3 (0f, 90f, 0f);
        this.transform.eulerAngles =  eulerrot;

        rotationAngles = new Vector3 (0f, 0f, 90f);
    }
    
    // Update is called once per frame
    void Update () 
    {
        this.transform.eulerAngles =  eulerrot;
         eulerrot += rotationAngles * Time.deltaTime;
    }
} 