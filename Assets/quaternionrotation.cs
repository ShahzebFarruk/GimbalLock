using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaternionrotation : MonoBehaviour
{

    public Vector3 eulerRotation;
    public Vector3 rotationAngles;

    void Start()
    {
        eulerRotation = new Vector3 (0f, 90f, 0f);

        Quaternion yRotation = Quaternion.AngleAxis (eulerRotation.y, Vector3.up);
        Quaternion xRotation = Quaternion.AngleAxis (eulerRotation.x, Vector3.right);
        Quaternion zRotation = Quaternion.AngleAxis (eulerRotation.z, Vector3.forward);
        this.transform.rotation =  yRotation * xRotation * zRotation;

        rotationAngles = new Vector3 (0f, 0f, 90f);
    }

    void Update()
    {
        Quaternion yRotation = Quaternion.AngleAxis (rotationAngles.y * Time.deltaTime, Vector3.up);
        Quaternion xRotation = Quaternion.AngleAxis (rotationAngles.x * Time.deltaTime, Vector3.right);
        Quaternion zRotation = Quaternion.AngleAxis (rotationAngles.z * Time.deltaTime, Vector3.forward);
        this.transform.rotation =  yRotation * xRotation * zRotation * this.transform.rotation;

       eulerRotation += rotationAngles * Time.deltaTime;

    }

}