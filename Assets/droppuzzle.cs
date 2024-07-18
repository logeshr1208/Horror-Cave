using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppuzzle : MonoBehaviour
{
    public GameObject dropobj_ui;
    public GameObject dropobj1;
    public GameObject dropobj2;
    public GameObject dropobj3;
    public GameObject dropobj4;
    public GameObject bridgeopenui;
    private void Update()
    {
        dropall();
    }


    void dropall()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("eeee");
            dropobj1.gameObject.SetActive(true);
            dropobj2.gameObject.SetActive(true);
            dropobj3.gameObject.SetActive(true);
            dropobj4.gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("drop puzzle");
            StartCoroutine(drop());
        }
    }

    IEnumerator drop()
    {
        dropobj_ui.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        dropobj_ui.gameObject.SetActive(false);
     
        bridgeopenui.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        bridgeopenui.gameObject.SetActive(false);
    }
}
