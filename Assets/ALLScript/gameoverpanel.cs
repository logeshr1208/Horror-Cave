using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class gameoverpanel : MonoBehaviour
{
   
    public bool taken;
    public int count=1;
    Rigidbody rb;
    AudioSource audioSource;
    private bool shouldStop = true;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
       rb = GetComponent<Rigidbody>();
        audioSource.Play();
    }
    private void Update()
    {
        /*if (shouldStop)
        {
            Debug.Log("bool");
            rb.velocity = Vector3.zero;

            rb.angularVelocity = Vector3.zero;
            return;
        }*/
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "puzzle1")
        {
            count += 1;
            other.gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "puzzle2")
        {
            count += 1;
            other.gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "puzzle3")
        {
            count += 1;
            other.gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "puzzle4")
        {
            Debug.Log("puzzle4");
            count += 1;
            other.gameObject.SetActive(false);

        }
        if (other.gameObject.tag == "danger")
        {
            Debug.Log("down");
            rb.useGravity = true;
        }
        if (other.gameObject.tag == "danger1")
        {
            Debug.Log("down");
            rb.useGravity = true;
        }



        if (other.gameObject.tag == "danger2")
        {
            Debug.Log("down");
            rb.useGravity = true;
        }
        if (other.gameObject.tag == "danger3")
        {
            Debug.Log("down");
            rb.useGravity = true;
        }
    }
   private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.name == "boundry (29)")  // or if(gameObject.CompareTag("YourWallTag"))
        {
            Debug.Log("collision");


        }
    }

}       
    
    


