using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public GameObject square;
    public string missileCount;
    public int numberOfMissiles = 0;

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 50, 40), "Fire!"))
        {
            fireMissile();
        }
        
        GUI.TextField (new Rect (700, 10, 100, 40), missileCount, 25);
    }

    private void Update()
    {
        // convert biến numberOfMissiles sang kiểu String
        missileCount = numberOfMissiles.ToString();
    }

    void fireMissile()
    {
        Vector3 tranform = new Vector3(square.transform.position.x + 1f, square.transform.position.y,
            square.transform.position.z);
        square.transform.position = tranform;
        numberOfMissiles++;
    }
}
