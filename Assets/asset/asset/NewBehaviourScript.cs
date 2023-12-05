using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bghome;
    public GameObject bgsetting;
    void Start()
    {
        bghome.SetActive(true);
        bgsetting.SetActive(false);
    }
    public void settingClicled()
    {
        bghome.SetActive(false);
        bgsetting.SetActive(true);
    }
    void Update()
    {
        
    }
}
