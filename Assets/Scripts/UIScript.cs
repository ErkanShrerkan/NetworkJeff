using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    Queue<float> fpsQueue = new Queue<float>();
    
    public Text displayText;
    float fpsToDisplay;
    int iAverage = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fpsToDisplay = (1 / Time.deltaTime);

        fpsQueue.Enqueue(fpsToDisplay);

        if (fpsQueue.Count > 5)
        {
            fpsQueue.Dequeue();
        }

        float average = fpsQueue.Sum() / fpsQueue.Count;
        
        int iAverage = (int)Math.Round(average, 0);

        displayText.text = iAverage + " fps";
    }
}
