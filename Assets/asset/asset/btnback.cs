using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnback : MonoBehaviour
{
    public GameObject bgsetting;
    public GameObject bghome;
    // Start is called before the first frame update
    void Start()
    {
        bgsetting.SetActive(true);
        bghome.SetActive(false);
    }
    
    public void btnbackClicked()
    {
        bgsetting.SetActive(false);
        bghome.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
