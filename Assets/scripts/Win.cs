using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public TMP_Text timerText;

    private int destroyedCible = 0;
    private int totalCible = 4;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TargetDestroyed()
    {
        destroyedCible++;

        // Vérifier si toutes les cibles ont été détruites
        if (destroyedCible >= totalCible)
        {
            // Mettre fin au jeu si toutes les cibles sont détruites
            EndGame();
        }
    }

    void EndGame()
    {
        // Marquer le jeu comme terminé
        gameIsOver = true;

        // Charger la scène de victoire si toutes les cibles sont détruites
        SceneManager.LoadSceneAsync(3);
    }
}
// commme tout les autres scripts créé après les erreurs il n'est pas comptabilisé par Untiy