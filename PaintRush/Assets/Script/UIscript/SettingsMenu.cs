using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private Text volText;
    [SerializeField] private int volNum;
    public AudioMixer audioMixer;
    private int volConversion;
    private int vol;
    private bool stopHigh,stopLow=false;
    //private bool active;

    private void Start()
    {
        vol = volNum;
        volConversion = -40;
    }
    public void SetVolumeHigh()
    {
        if(stopHigh==true)
        {
            vol += 0;
            volConversion += 0;
        }
        if (vol == 10)
        {
            stopHigh = true;
        }
        else
        {
            vol += 1;
            volText.text = vol.ToString();
            volConversion += 9;
            audioMixer.SetFloat("Volume", volConversion);
            stopLow = false;
        }
    }
    public void SetVolumeLow()
    {
        if(stopLow==true)
        {
            vol += 0;
            volConversion += 0;
        }
        if (vol <= 0f)
        {
            stopLow = true;
        }
        else
        {
            vol -= 1;
            volText.text = vol.ToString();
            volConversion -= 9;
            audioMixer.SetFloat("Volume", volConversion);
            stopHigh = false;
        }
    }
}
