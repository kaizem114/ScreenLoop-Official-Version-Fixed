using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{//Player Infos
    public float Move_speed;
    public Rigidbody Player_rb;
    public AudioSource Player_ears;
    public float sensY;
    public float sensX;
    public Transform orientation;
    float xRotation;
    float yRotation;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        //Camera Initial Setup
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        yRotation += mouseX;

        xRotation -= mouseY;


        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //Rotate Camera
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);



        Vector3 camForward = transform.forward;
        Vector3 camRight = transform.right;
        
        //basic movement
        //Move Forward
        if (Input.GetKey(KeyCode.W))
        {

            transform.position += Move_speed * Time.deltaTime * camForward.normalized;

        }
        //Move Backward
        if (Input.GetKey(KeyCode.S))
        {

            transform.position += Move_speed * Time.deltaTime * -camForward.normalized;

        }
        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Move_speed * Time.deltaTime * -camRight.normalized;


        }
        //Move Right
        if (Input.GetKey(KeyCode.D))
        {

            transform.position += Move_speed * Time.deltaTime * camRight.normalized;

        }
    }
}
