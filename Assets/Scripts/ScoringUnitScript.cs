using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringUnitScript : MonoBehaviour
{
    public Text ScoreText;
    private int score;
    
    private void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            score++;
            ScoreText.text = "Score: " + score.ToString();
            Destroy(col.gameObject);
        }
    }
   

   
}
