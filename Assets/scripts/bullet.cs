using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life = 3;
    
    
    void Awake()
    {
        Destroy(gameObject, life);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cible")) // Vérifie si l'objet en collision est une cible
        {
            Destroy(collision.gameObject); // Détruit la cible
        }

        Destroy(gameObject); // Détruit la balle
    }
}