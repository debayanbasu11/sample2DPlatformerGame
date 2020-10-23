using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    [SerializeField] AudioClip CoinPickUpSFX;
    [SerializeField] int pointsForCoinPickup = 50;
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);
        AudioSource.PlayClipAtPoint(CoinPickUpSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
