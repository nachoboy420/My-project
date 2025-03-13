using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerCollection : MonoBehaviour
{


    private int score =0;
    public TMP_Text scoreText;


    private void OnTriggerEnter(Collider other)
    {
        // only destroy if collectable
        Debug.Log(other.tag);
        if (other.CompareTag("collectibile"))
        {
            AddScore(1);
            Destroy(other.gameObject); 
       
        
        }


    }


    private void AddScore (int points)
    {
        score = score + points;
        scoreText.text = $"<b>Score:</b> {score}";
    }

}
