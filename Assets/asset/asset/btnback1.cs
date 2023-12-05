using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnback1 : MonoBehaviour
{
    public GameObject video;
    public GameObject bgsetting;
    void Start()
    {
        video.SetActive(true);
        bgsetting.SetActive(false);
    }

    public void btnback1Clicked()
    {
        video.SetActive(false);
        bgsetting.SetActive(true);
    }

    void Update()
    {
        
    }
}
