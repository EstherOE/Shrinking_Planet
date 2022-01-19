using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {

	
	void Update ()
	{
		
	}

	public void Restart()
    {
		GameManager.instance.Restart();
		//GetComponent<RectTransform>().localScale = Vector3.one * Planet.Size;
	}

	public void Menu ()
	{
		SceneManager.LoadScene("Menu");
	}

}
