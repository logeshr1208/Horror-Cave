using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour
{
    //capsule puzzle
    public GameObject capsules;
    public GameObject capsule1;
    public int score;
    Playercontrol addscore;
    public GameObject capsule2_ui;
    void Start()
    {
        addscore = GameObject.FindGameObjectWithTag("Player").GetComponent<Playercontrol>();
        capsules.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            addscore.finalscore += 1;
            StartCoroutine(capsulesui());
            capsules.gameObject.SetActive(false);
            capsule1.gameObject.SetActive(true);
          
        }
    }

    IEnumerator capsulesui()
    {
        capsule2_ui.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        Debug.Log("false");
        capsule2_ui.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
