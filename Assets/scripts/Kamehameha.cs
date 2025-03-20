using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Kamehameha : MonoBehaviour
{

    public GameObject fireballPrefab;
    public float spawnTimer = 1;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnFireballRoutine());
    }
    private IEnumerator SpawnFireballRoutine()

    {
        while (true)

        {

            yield return new WaitForSeconds(spawnTimer);
            Instantiate(fireballPrefab, transform.position, transform.rotation);
            //instantiate means to create a copy of something

        }


    }

}