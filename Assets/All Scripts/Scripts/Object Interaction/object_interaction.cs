using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit,5f))
        {
            if (hit.collider.CompareTag("gun"))
            {

                Debug.Log("I see a gun !");



            }
        }
    }
}
