using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
//dit verteld dat als je op play drukt dat de game ook echt gaat beginnen 
    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
//dit verteld dat de game word gestopt  en dat wordt exstra aan gegeven met debug.log
    public void quitgame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    
    
}
