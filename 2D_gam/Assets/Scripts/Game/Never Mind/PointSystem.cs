﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public static int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(score < 0)
        {
            score = 0;
        }
    }
}
