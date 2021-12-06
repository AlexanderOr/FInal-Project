using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    
    int collected = 0;
    public GameObject winExit;
    public int levelRec = 10;

    private void OnTriggerEnter(Collider other)
    {
        
        //On interact with object named Key , the object is destroyed

        Destroy(other.gameObject);

        //marks key as held
        collected = collected + 1;
        win();
    }
    public void win()
    {
        if (collected == levelRec)
        {
            
            //"opens" the exit
            winExit.SetActive(true);
        }
        
    }
}
