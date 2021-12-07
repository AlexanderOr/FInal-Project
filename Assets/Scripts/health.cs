using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int HP;
    public int numOfHearts;

    public GameObject loseUI;
    public MouseLook mouseLook;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        //if hp is lowered the hearts are lowered
        if (HP > numOfHearts)
        {
            HP = numOfHearts;
        }

        //checks to see if the heart sprite should be empty or full

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < HP)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < hearts.Length)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = true;
            }
        }
        if (HP == 0)
        {

            Time.timeScale = 0;

            mouseLook.enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            loseUI.SetActive(true);
        }

    }


}