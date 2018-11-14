using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelsControl : MonoBehaviour {

	 public void firstLevel()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }
	 public void secondLevel()
    {
        SceneManager.LoadScene("Scenes/level2");
    }
	 public void thirdLevel()
    {
        SceneManager.LoadScene("Scenes/level3");
    }
	public void Back()
             
         {
        SceneManager.LoadScene("Scenes/menu");
         }

}

