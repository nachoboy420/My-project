using JetBrains.Annotations;
using UnityEngine;
using TMPro;


public class Health : MonoBehaviour
{
    public Vector3 respawnPosition;

    public int points = 5;
    public TMP_Text healthText;
    public EndScreenAnimation gameOverScreen;
    private void Start()
    {
        respawnPosition = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trap"))
        {

            Damage(1);
        }


        if (other.CompareTag("Checkpoint"))
        {

            // we can set the position based on the checkpoint so this acts as a guaranteed safe spot 
            respawnPosition = other.transform.position;
            respawnPosition.y = transform.position.y;

        }


    }
    // to remove some health points 
    private void Damage(int value)
    {
        points = points - value;
        healthText.text = $"Peter points {points}";

        //HW  DO NOT DESTROY MOVE PLAYER 2 START AND RESET POINTS TO 5

        transform.position = respawnPosition;
        //points = 5;

        if (points < 1)
        {
            gameOverScreen.StartFade();
            Destroy(gameObject);

        }




    }


}
