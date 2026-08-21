using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class object_interaction : MonoBehaviour
{
    public bool holding_gun;
    public GameObject arms_holding_gun;
    public GameObject main_arms;
    // Start is called before the first frame update
    void Start()
    {
        //Item Initial Setup
        arms_holding_gun.gameObject.SetActive(false);
        holding_gun = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5f))
        {
            if (hit.collider.CompareTag("gun") && Input.GetKeyDown(KeyCode.E))
            {

                Debug.Log("I see a gun !");
                //Gun is in player hands
                holding_gun = true;
                StartCoroutine(arm_switch());
            }
        }
       
        if (Input.GetKeyDown(KeyCode.F))
        {
            holding_gun = false;
            arms_holding_gun.gameObject.SetActive(false);
           
        }
        if (holding_gun == false)
        {
            StopCoroutine(arm_switch());
            main_arms.gameObject.SetActive(true);
        }
    }
    IEnumerator arm_switch()
    { //Disable Mains Arms
        main_arms.gameObject.SetActive(false);
        //Add animation 
        yield return new WaitForSeconds(2);
        arms_holding_gun.gameObject.SetActive(true);
    }
}
