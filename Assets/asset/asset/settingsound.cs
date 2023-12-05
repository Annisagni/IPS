using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsound : MonoBehaviour
{
    public AudioSource Sound;
    public void clicksilider(float nilaislider)
    {
        Sound.volume = nilaislider;
    }
}
