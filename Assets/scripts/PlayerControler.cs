using System;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
   
    void Start()
    {

    }

    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxis("horizontal"),
            0, Input.GetAxis("vertical"));
        transform.Rotate(0, 3, 0);
        transform.Translate(dir * Time.deltaTime *  speed);




    }
}
