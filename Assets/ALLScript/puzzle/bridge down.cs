using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class bridgedown : MonoBehaviour
{
  private Rigidbody rb;
    public GameObject targetRb;
    void Start()
    {
       rb  = targetRb.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("constain");
            rb.constraints  &= ~RigidbodyConstraints.FreezePositionY;
        }
    }
    
}
