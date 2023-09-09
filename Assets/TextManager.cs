using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    float elapsedTime = Goal.elapsedTime;

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Goal.elapsedTime;
        timerText.text = "Time: " + elapsedTime.ToString("F2") + "s";
    }
}
