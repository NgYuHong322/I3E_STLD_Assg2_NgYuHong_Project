using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Author: NgYuHong
 * Date: 28/6/24
 * Description: audio slider 
 */
public class audioVolumeSlider : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {   
        // slider value is set to volume when start
        volumeSlider.value = PlayerPrefs.GetFloat("volume");
    }
    public void changeVolume()
    {   
        // saves current value
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
        PlayerPrefs.Save();
    }
    void Update()
    {
        // make sure global volume is same throughout
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
}
