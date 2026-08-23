using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class os_system : MonoBehaviour
{
    public GameObject lobby;
    public GameObject browser;
    // Start is called before the first frame update
    void Start()
    {
        
        //Start With the main menu, all of the time.
        

    }

    public void Gotointernet()
    {

        lobby.gameObject.SetActive(false);
    }
    //Give access to internet
    public void Browser()
    {

        lobby.gameObject.SetActive(false);
    }

    //Go to the Minigame
    public void Minigame()
    {

        lobby.gameObject.SetActive(false);
    }


    //Turn on or off the computer

    void Update()
    {
        


    }
}
