using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class btnclick : MonoBehaviour {

	 public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/levels");
    }
	public void ClickExit()
             
         {
             Application.Quit();
         }

}

