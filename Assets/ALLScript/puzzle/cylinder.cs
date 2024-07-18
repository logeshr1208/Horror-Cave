using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    public int score;
    Playercontrol addscore;
    public GameObject cylinders;
    public GameObject cylinder1;
    public GameObject cyliinderui;
    void Start()
    {
        addscore = GameObject.FindGameObjectWithTag("Player").GetComponent<Playercontrol>();
        cylinders.gameObject.SetActive(true);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            addscore.finalscore += 1;
            StartCoroutine(cyliui());
            cylinders.gameObject.SetActive(false);
            cylinder1.gameObject.SetActive(true);
           
        }
    }

    IEnumerator cyliui()
    {
        cyliinderui.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        Debug.Log("false");
        cyliinderui.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}