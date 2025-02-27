using JetBrains.Annotations;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trap"))
        {

            Damage(1);

                

        }
           

    }
    // to remove some health points 
    private void Damage(int value)
    {
        points = points - value;
        if (points < 1)
        {

            //HW  DO NOT DESTROY MOVE PLAYER 2 START AND RESET POINTS TO 5 
            Destroy(gameObject);

        }




    }



}
