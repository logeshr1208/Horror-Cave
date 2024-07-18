using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class puzzle : MonoBehaviour
{
    //final bridge open script
      Animator animator;
    Playercontrol finaltotal;
   // public GameObject puzzle_checkpanel;
    //public GameObject correct_puzzle;
    Rigidbody rb;
    private void Start()
    {
             animator = GetComponent<Animator>();

             finaltotal =  GameObject.FindGameObjectWithTag("Player").GetComponent<Playercontrol>();
        rb=GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
          if (other.gameObject.tag == "Player")
        {
            
          if(finaltotal.finalscore == 4)
             {
                Debug.Log(finaltotal.finalscore);
               // correct_puzzle.gameObject.SetActive(true);
                animator.SetBool("New Bool", true);
             }
            if (finaltotal.finalscore != 4)
            {
                Debug.Log(finaltotal.finalscore);
               // StartCoroutine(puzzlenotmatch());
                
            }
        }
          
    }
    IEnumerator puzzlenotmatch()
    {
       // puzzle_checkpanel.gameObject.SetActive(true);
        yield return new WaitForSeconds(10.0f);
        //puzzle_checkpanel.gameObject.SetActive(false);
    }

}
