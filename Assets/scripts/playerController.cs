using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    private float speed = 30.0f;
    private float turnSpeed=70.0f;
    private float horizontalInput ;
    private float forwardInput ;
    public int counter=0;
    public int maxCoins;
    // Start is called before the first frame update
    void Start()
    {
        maxCoins=GameObject.FindGameObjectsWithTag("Coin").Length;
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
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Coin"))
        {
        //Destroy(other.gameObject);
        other.gameObject.SetActive(false);
        Debug.Log("Collision happened");
        counter++;
        Debug.Log("Coin Collected"+counter);
        if(counter==maxCoins){
            Debug.Log("Won");
            GetComponent<playerController>().enabled=false;
        }
        }
        if(other.gameObject.CompareTag("Slow"))
        {
        //Destroy(other.gameObject);
        other.gameObject.SetActive(false);
        Debug.Log("Collision happened");
        speed=10.0f;
        }
        if(other.gameObject.CompareTag("Fast"))
        {
        //Destroy(other.gameObject);
        other.gameObject.SetActive(false);
        Debug.Log("Collision happened");
        speed=60.0f;
        }
         if(other.gameObject.CompareTag("Lost"))
            {Debug.Log("Lost The Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

        
        }
       
        

}
