using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healheart : MonoBehaviour
{
    
    public health HpUp;


    private void OnTriggerEnter(Collider other)
    {
        

        //On interact with object named Key , the object is destroyed
        if (other.gameObject.name == "heart_case")
        {
            Destroy(other.gameObject);
            HpUp.HP++;
        }
        if (other.gameObject.name == "heart_case (1)")
        {
            HpUp.HP++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "heart_case (2)")
        {
            HpUp.HP++;
            Destroy(other.gameObject);
        }
    }
}
