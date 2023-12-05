using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnnext : MonoBehaviour
{
    public GameObject bgsetting;
    public GameObject materi3;
    // Start is called before the first frame update
    void Start()
    {
        bgsetting.SetActive(true);
        materi3.SetActive(false);
    }

    public void btnnextClicked()
    {
        bgsetting.SetActive(false);
        materi3.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
