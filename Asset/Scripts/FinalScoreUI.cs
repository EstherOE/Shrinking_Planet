using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
[RequireComponent(typeof(Text))]
public class FinalScoreUI : MonoBehaviour {
	float volume;
	float playerScore;
	void Start()

	{


		if (PlayerPrefs.HasKey("masterVolume"))
		{
			volume = PlayerPrefs.GetFloat("masterVolume");
		}
		playerScore = Planet.Score;

		DisplayScore();
	}
	
	void Update()
    {
		PlayerPrefs.SetFloat("masterVolume", playerScore);
		
		
	}
   void DisplayScore()
	{
		if(playerScore>volume)
        {
			

			GetComponent<Text>().text = "Score: " + Planet.Score.ToString("0.#") + "\n"
			+ "HighScores: " + volume.ToString("0.#");
			
		}

	

        else
        {
			
			GetComponent<Text>().text = "Scores:" + Planet.Score.ToString("0.#") + "\n" +
				"HighScores: " + volume.ToString("0.#") ;
			
		}

	}


	

	

	
}
