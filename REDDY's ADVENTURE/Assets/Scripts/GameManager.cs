using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
	public GameObject gameOverPanel;
	public GameObject LevelCompletePanel;
	public void GameOver()
	{

		if (gameEnded == false)
		{
			gameEnded = true;

			gameOverPanel.SetActive(true);
		}

	}

	public void MainMenu()
	{

		SceneManager.LoadScene("Menu");

	}
	public void Restart()
	{

		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}


	
	public void quit()
	{

		Application.Quit(); //call quit function
	}




	public void LevelComplete() {
		
		LevelCompletePanel.SetActive(true);
	}


}
