using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMpro;
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            // GameOverr();
            timerText.color = Color.red;
            public void GameOver() 
            {
                SceneManager.LoadSceneAsync(2);
            }
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
// j'avoue ne pas comprendre pourquoi le  TMpro ne marche pas sachant que le package TextMesh Pro est installé dans le projet
// Encore une fois ce script a été créée après mes erreurs donc Unity "l'ignore" tant qu'il y a des erreurs
// normalement ce script aurait du être ajouté à Canvas
// Il aurait aussi du être ajouté a Timer dans la scene nommé scene, et la j'aurais pus ajouter mon Text a Timer Text

}