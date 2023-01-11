using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI Myscoretext;

    public static int ScoreNum;
    
    
    void Start()
    {
        ScoreNum = 0;
    }

    private void Update()
    {
        Myscoretext.text = "Score : " + ScoreNum;
    }
}
