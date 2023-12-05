using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnexit : MonoBehaviour
{
    public GameObject bgsound;
    public GameObject bgsetting;
    // Start is called before the first frame update
    void Start()
    {
        bgsound.SetActive(true);
        bgsetting.SetActive(false);
    }

    public void btnexitClicked()
    {
        bgsound.SetActive(false);
        bgsetting.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
