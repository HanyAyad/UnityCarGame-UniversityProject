using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 30.0f;
    private float turnSpeed=70.0f;
    private float horizontalInput ;
    private float forwardInput ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     horizontalInput = Input.GetAxis("Horizontal");   
     forwardInput = Input.GetAxis("Vertical");   
        //move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        //Rotates the vehicle to left and right
        transform.Rotate(Vector3.up,turnSpeed*horizontalInput*Time.deltaTime);
    }
}
