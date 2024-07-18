using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlimage : MonoBehaviour
{
    //front ui
    public GameObject control_image;
    public GameObject openpanel;

    void Start()
    {

        StartCoroutine(showfew());
       // StartCoroutine(openui());
    }

   IEnumerator showfew()
    {
       // yield return new WaitForSeconds(1.0f);
       // gameObject.SetActive(false);
        openpanel.gameObject.SetActive(true);
        yield return new WaitForSeconds(5.0f);
       
        gameObject.SetActive(false);

    }

  /* IEnumerator openui()
    {

        yield return new WaitForSeconds(3.0f);
        openpanel.gameObject.SetActive(false);

       // penpanel.gameObject.SetActive(false);
    }*/
}
