using System.Collections;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    //player momenment
    public float mouseturn = 2.0f;
    public float walkSpeed = 5.0f;
    private float pitch_Y = 0.0f;
    private float yaw_X = 0.0f;
    private Rigidbody rb;
    public int finalscore;
   public AudioSource AudioSource;
  
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = gameObject.GetComponent<Rigidbody>();    
        AudioSource = GetComponent<AudioSource>();
        AudioSource.Play();

    }
    void Update()
    {     
            Look();     
        Movement();
      
    }

    void Look()
    {
        pitch_Y -= Input.GetAxisRaw("Mouse Y") * mouseturn * Time.deltaTime;
        pitch_Y = Mathf.Clamp(pitch_Y, -90.0f, 90.0f);

        yaw_X += Input.GetAxisRaw("Mouse X") * mouseturn * Time.deltaTime;

        //mouse rotate camera will rotate
        Camera.main.transform.localRotation = Quaternion.Euler(pitch_Y, yaw_X, 0);
    }
    void Movement()
    {
        // input 
        float moveForward = Input.GetAxis("Vertical") * walkSpeed;
        float moveRight = Input.GetAxis("Horizontal") * walkSpeed;

       // camera's orientation
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;
    
        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        //  movement direction
        Vector3 moveDirection = forward * moveForward + right * moveRight;

        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);
    }

   

}










