using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoffFlashlight : MonoBehaviour
{
    public GameObject flight;
    public bool toggle;
    public AudioSource toggleSound;

    void Start()
    {
        if(toggle == false)
        {
            flight.SetActive(false);
        }
        else
        {
            flight.SetActive(true);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            toggle = !toggle;
            //toggleSound.Play();
            if(toggle == false)
            {
                flight.SetActive(false);
            }
            else
            {
                flight.SetActive(true);
            }

        }
    }
}
