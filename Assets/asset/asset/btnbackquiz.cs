using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnbackquiz : MonoBehaviour
{
    public GameObject quiz;
    public GameObject bgsetting;
    void Start()
    {
        quiz.SetActive(true);
        bgsetting.SetActive(false);
    }

    public void btnbackquizClicked()
    {
        quiz.SetActive(false);
        bgsetting.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
