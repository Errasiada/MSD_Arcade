using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public byte itemsOnLevel;
    [SerializeField] private byte playerLives = 4;

    public byte PlayerLives
    {
        get => playerLives;
        set
        {
            playerLives = value;
            if (playerLives == 0)
            {
                Destroy(GameObject.Find("Player"));
            }
        }
    }
}
