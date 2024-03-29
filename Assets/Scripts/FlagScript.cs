using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Cronometro cronometro = FindObjectOfType<Cronometro>();
            if (cronometro != null)
            {
                cronometro.DetenerCronometro();

            }
        }
    }
}
