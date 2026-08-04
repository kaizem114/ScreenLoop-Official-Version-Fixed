using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{//Player Infos
    public float Move_speed;
    public Rigidbody Player_rb;
    public AudioSource Player_ears;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camForward = transform.forward;
        Vector3 camRight = transform.right;


    }
}
