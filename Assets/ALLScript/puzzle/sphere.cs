using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    public int score;
    Playercontrol addscore;
    public GameObject spheres;
    public GameObject sphere1;
    public GameObject sphere2_image;
    // Start is called before the first frame update
    void Start()
    {
        addscore = GameObject.FindGameObjectWithTag("Player").GetComponent<Playercontrol>();
        spheres.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            addscore.finalscore += 1;
            StartCoroutine(shpere());
            spheres.gameObject.SetActive(false);
            sphere1.gameObject.SetActive(true);
         
           

          
        }
    }

    IEnumerator shpere()
    {
        sphere2_image.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        Debug.Log("false");
        sphere2_image.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
