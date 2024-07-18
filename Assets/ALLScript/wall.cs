using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class wall : MonoBehaviour
{
    //4puzzle taken script
    public int score;
    Playercontrol addscore;
    public GameObject cube;
    public GameObject cube1;
    public GameObject cubeui;

    private void Start()
    {
        addscore = GameObject.FindGameObjectWithTag("Player").GetComponent<Playercontrol>();
        cube.gameObject.SetActive(true);
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("puzzle Taken");
            addscore.finalscore+= 1;
            StartCoroutine(cubesui());
            cube.gameObject.SetActive(false);
            cube1.gameObject.SetActive(true);
         
          
        }

       
    }

    IEnumerator cubesui()
    {
        cubeui.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        Debug.Log("false");
        cubeui.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }

}


