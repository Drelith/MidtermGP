using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public int collectedPoints = 0;
    public int WIN_AMOUNT = 5;
    public int currentHP = 3;

    // Start is called before the first frame update
    void Start()
    {   
        StartCoroutine(Enemy());
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHP == 0)
        {
            print("YOU LOSE!");
            Time.timeScale = 0f;
            currentHP--;
        }
    }

    private IEnumerator Enemy()
    {
        while(currentHP > 0)
        {
        yield return new WaitForSeconds(Random.Range(5f,10f));
        currentHP--;
        print($"BOOM HEADSHOT(-1 hp) HP left: {currentHP}");
        }
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            Destroy(other.gameObject);
            collectedPoints++;
            print($"{WIN_AMOUNT - collectedPoints} Coins left!");
            if(collectedPoints >= WIN_AMOUNT)
            {
                print("YOU WIN!");
                Time.timeScale = 0f;
            }
        }

        if (other.tag == "HP" && currentHP < 3)
        {
            Destroy(other.gameObject);
            currentHP++;
            print($"+1 HP, current HP: {currentHP}");
        }
    }

}
