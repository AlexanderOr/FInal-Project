using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToxicSlime : MonoBehaviour
{
    public string name;
    public GameObject hitsound;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 audioSpawnpoint = other.transform.position;
        Instantiate(hitsound, audioSpawnpoint, Quaternion.identity);


        //Destroy() is the base function for destroying components and objects in a scene
        //you need to specify that you are referring to a game object
        //Destroy(this), for instance, will destroy the component, not the object 
        //Destroy(this.gameObject) will destroy the object where this component is


        //Destroy(other.gameObject);


        SceneManager.LoadScene(name);

    }

}