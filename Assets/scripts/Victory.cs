using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public void PlayGame() 
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
// normalement les deux fonctions auraient du apparaitre pour que dans le On Click des boutons je puisse les mettre
// ceux-ci n'apparaissent pas car je les ais créé après les erreurs donc Unity ne les considérent pas
// pour le bouton play la fonction PlayGame qui aurait lancé la scene 1 soit le jeu 
// et pour le bouton exit la fonction QuitGame qui aurait, quand cliqué, quitter l'application
// ce script aurait du être ajouté a la Main Camera
}
