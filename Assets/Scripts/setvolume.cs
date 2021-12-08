using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class setvolume : MonoBehaviour
{

    public AudioMixer mixer;
    public Slider volslider;
    private void Start()
    {
        volslider.value = PlayerPrefs.GetFloat("musicvol", 1f);
        mixer.SetFloat("volume",PlayerPrefs.GetFloat("musicvol"));
    }

    public void setlevel(float sliderValue)
    {
        mixer.SetFloat("musicvol", Mathf.Log10(sliderValue)*20);
    }



}
