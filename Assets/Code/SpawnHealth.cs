using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealth : MonoBehaviour
{
    public GameObject HPPrefab;
    private GameObject HPClone;
    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x <= 5; x++)
        {
            StartCoroutine(spawnHP());
        }
        print("Spawning 5 HP DONE!");
    }

    // Update is called once per frame
    private IEnumerator spawnHP()
    {
        Vector3 randomPosition = new Vector3 (Random.Range(-50,50), 1, Random.Range(-50,50));
        HPClone = Instantiate(HPPrefab, randomPosition, transform.rotation);
        HPClone.tag = "HP";
        yield return null;
    }
}
