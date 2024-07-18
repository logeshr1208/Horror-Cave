using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class Enenmy : MonoBehaviour
{
 
   public Transform pointA;  
    public Transform pointB;  
  [SerializeField]  private float speed = 20f;  

    private Transform targetPoint;  
    public bool movingToA;
    public GameObject _GameOverPanel;

    void Start()
    {
        targetPoint = pointA;  
        movingToA = true;  
    }

    void Update()
    {
        PatrolBetweenPoints();
    }

    void PatrolBetweenPoints()
    {
     
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

       
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        {
           
            if (movingToA)
            {
                targetPoint = pointB;
                transform.Rotate(0, 180, 0);
                movingToA = false;
            }
            else
            {
                targetPoint = pointA;
                transform.Rotate(0, -180, 0);
                movingToA = true;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("gameover");
            _GameOverPanel.gameObject.SetActive(true);

            StartCoroutine(end());

        }
    }

    IEnumerator end()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   


}


/* public GameObject pointA;
   public GameObject pointB;
 private Transform currentpoint;
   Rigidbody Rigidbody;
   public float speed;
   void Start()
   {
       Rigidbody = GetComponent<Rigidbody>();
       currentpoint = pointB.transform;
   }

   // Update is called once per frame
   void Update()
   {
       Vector2 point= currentpoint.position -transform.position;
       if (currentpoint == pointB.transform)
       {
           Debug.Log("if");
          // Rigidbody.velocity = new Vector2(speed, 0);
          transform.Translate(Vector3.forward *speed *Time.deltaTime);
       }
       else
       {
           transform.Translate(Vector3.back * speed * Time.deltaTime);
       }

       if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointB.transform)
       {
           currentpoint = pointA.transform;
       }

       if (Vector2.Distance(transform.position, currentpoint.position) < 0.5f && currentpoint == pointA.transform)
       {
           currentpoint = pointB.transform;
       }

   }*/