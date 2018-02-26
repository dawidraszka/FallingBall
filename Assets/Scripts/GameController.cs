using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text score;
	public Text restart;

	private bool isRestartEnabled;

	void Update()
	{
		if (isRestartEnabled && Input.GetButtonDown("Restart"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

	public void UpdateScore(float y)
	{
		score.text = "Score: " + Mathf.RoundToInt(Mathf.Abs(y)) + " m";
	}
	
	public void EnableRestart()
	{
		isRestartEnabled = true;
		restart.gameObject.SetActive(true);
	}
}
