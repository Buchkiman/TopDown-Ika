using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] int points;
    [SerializeField] TextMeshProUGUI pointtxt;
    
    public void IncreasPoints()
    {
        points = points + 1;
        //points += 1
        //points ++;

        pointtxt.text = "Points: " + points;
    }

}

