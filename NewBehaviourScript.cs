using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bghome;
    public GameObject bgsetting;
    // Start is called before the first frame update
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
