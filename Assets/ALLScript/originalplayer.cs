using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class originalplayer : MonoBehaviour
{
 

    public float speed = 5.0f;
   // public int finalscore;

    private Rigidbody rb;

    void Start()
    {
      
        rb = GetComponent<Rigidbody>();
    

 
      //  Debug.Log("collected Puzzles: " + finalscore);
    }

    void Update()
    {
     
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

   
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

    
        rb.AddForce(movement * speed, ForceMode.Impulse);
    }
}










