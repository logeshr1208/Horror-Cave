using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falldown : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Translate(Vector3.forward *speed*Time.deltaTime);
    }
}



/*public GameObject targetobj;
Rigidbody rb;
public GameObject gameoverpanel;
private void Start()
{
    rb = GetComponent<Rigidbody>();
}
private void OnTriggerEnter(Collider other)
{
    if (other.gameObject== targetobj)
    {
        Debug.Log("falldown");
        Rigidbody target = targetobj.GetComponent<Rigidbody>();
        target.useGravity = true;
        StartCoroutine(gameover());
    }
}
IEnumerator gameover()
{
   gameoverpanel .gameObject.SetActive(true);
    yield return new WaitForSeconds(5.0f);
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}*/