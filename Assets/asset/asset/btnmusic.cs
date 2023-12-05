using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnmusic : MonoBehaviour
{
    public GameObject bgsetting;
    public GameObject bgsound;
    // Start is called before the first frame update
    void Start()
    {
        bgsetting.SetActive(true);
        bgsound.SetActive(false);
    }

    public void btnmusicCliclked()
    {
        bgsetting.SetActive(false);
        bgsound.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
