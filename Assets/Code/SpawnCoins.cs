using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coinPrefab;
    private GameObject coinClone;
    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x <= 15; x++)
        {
            StartCoroutine(spawnCoin());
        }
        print("Spawning 15 Coins DONE!");
    }

    // Update is called once per frame
    private IEnumerator spawnCoin()
    {
        Vector3 randomPosition = new Vector3 (Random.Range(-50,50), 1, Random.Range(-50,50));
        coinClone = Instantiate(coinPrefab, randomPosition, transform.rotation);
        coinClone.tag = "Coin";
        yield return null;
    }
}
