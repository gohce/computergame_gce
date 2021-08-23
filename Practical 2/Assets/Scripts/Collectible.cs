using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    GameController gc;
    int gemValue = 10;

    void onTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject); // this gem(this game object) will dissapear from the screen
            Debug.Log("Enter Collider Gem");
            gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
            if (gameObject.ComparaTag("blueGems"))
            {
                gc.changeScore(gameValue + 30);
            }

            if (gameObject.ComparaTag("greenGems"))
            {
                gc.changeScore(gameValue + 20);
            }

            else
            {
                gc.changeScore(gameValue + 10);
            }

        }
    }
}
