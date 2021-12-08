using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pickup : MonoBehaviour
{

    public GameObject pickupsound;
    int collected = 0;
    public GameObject winExit;
    public int levelRec = 10;
    public Text pickupText;
    public MouseLook mouseLook;
    public PauseMenu pauseMenu;
    private void OnTriggerEnter(Collider other)
    {

        //On interact with object named Key , the object is destroyed
        if (other.gameObject.name != "heart_case")
            if (other.gameObject.name != "heart_case (1)")
                if (other.gameObject.name != "heart_case (2)")
                {
                        Destroy(other.gameObject);


                    Vector3 audioSpawnpoint = other.transform.position;
                    Instantiate(pickupsound, audioSpawnpoint, Quaternion.identity);

                    //marks key as held
                    collected = collected + 1;
                       pickupText.text = collected + " / " + levelRec;
        
                       win();
                }
 
    }
    public void win()
    {
        if (collected == levelRec)
        {
            
            //"opens" the exit
            winExit.SetActive(true);
            Time.timeScale = 0;
            mouseLook.enabled = false;
            pauseMenu.enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            
        }
        
    }
    public void LoadLevel(string name)
    {
        Time.timeScale = 1;
        mouseLook.enabled = true;
        pauseMenu.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        Application.Quit();
        print("you quit the game");

    }
}
