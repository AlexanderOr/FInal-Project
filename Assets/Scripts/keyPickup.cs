using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPickup : MonoBehaviour
{
    bool keyHeld = false;
    public GameObject winExit;

    private void OnTriggerEnter(Collider other)
    {

        //On interact with object named Key , the object is destroyed
        if (other.gameObject.name == "Key")
        {
            Destroy(GameObject.Find("Key"));

            //marks key as held
            if (!keyHeld)
            {
                keyHeld = true;
            }
            openExit();
        }
    }
    public void openExit()
    {
        if (keyHeld == true)
        {

            //"opens" the exit
            winExit.SetActive(true);
        }

    }
}
