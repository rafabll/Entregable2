using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private bool isGameOver;
   
    [SerializeField] private int playerHP = 100;

    public int damage = 30;


    // Start is called before the first frame update
    void Start()
    {
        playerHP -= damage; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            if (playerHP <= 0)
            {
                Debug.Log(message: "Te has quedado sin vida… GAME OVER");
            }
            else if (playerHP < 20)
            {
                Debug.Log(message: "¡Tienes poca vida!");
            }
            else
            {
                Debug.Log(message: $"Vas bien de vida, tienes {playerHP} puntos de vida");
            }
        }
        else
        {
            Debug.Log(message: "GAME OVER");
        }
    }
}
