using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerShip : MonoBehaviour
{
    public GameObject shipPrefab;
    public float respawnTime = 1f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shipWave());
    }

    private void spawnShip()
    {
        Instantiate(shipPrefab, transform.position, shipPrefab.transform.rotation);
    }

    IEnumerator shipWave()
    {   while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnShip();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
