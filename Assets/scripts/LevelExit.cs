using UnityEngine;

public class LevelExit : MonoBehaviour
{



    public EndScreenAnimation winScreen;

    private void OnTriggerEnter (Collider other)


    {
        if (other.CompareTag("Player"))
        {

            // turns off player
            other.gameObject.SetActive(false);
            winScreen.StartFade();





        }


      
    }

}
