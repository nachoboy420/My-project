using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // only destroy if collectable
        Debug.Log(other.tag);
        if (other.CompareTag("collectibile"))

        { Destroy(other.gameObject); 
        }


    }

}
