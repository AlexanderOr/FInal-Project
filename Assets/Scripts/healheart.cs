using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healheart : MonoBehaviour
{

    public health HpUp;
    public GameObject hpsound;

    
    private void OnTriggerEnter(Collider other)
    {
        if (HpUp.HP < 5)
        {


            //On interact with object named Key , the object is destroyed
            if (other.gameObject.name == "heart_case")
            {
                Destroy(other.gameObject);
                HpUp.HP++;
                Vector3 audioSpawnpoint = other.transform.position;
                Instantiate(hpsound, audioSpawnpoint, Quaternion.identity);
            }
            if (other.gameObject.name == "heart_case (1)")
            {
                HpUp.HP++;
                Destroy(other.gameObject);
                Vector3 audioSpawnpoint = other.transform.position;
                Instantiate(hpsound, audioSpawnpoint, Quaternion.identity);
            }
            if (other.gameObject.name == "heart_case (2)")
            {
                HpUp.HP++;
                Destroy(other.gameObject);
                Vector3 audioSpawnpoint = other.transform.position;
                Instantiate(hpsound, audioSpawnpoint, Quaternion.identity);
            }
        }
    }
}
