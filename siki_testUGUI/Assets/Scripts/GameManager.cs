using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public void OnStartGame(int sceneToLoad){
		//int sceneToLoad = 1;
		Application.LoadLevel(sceneToLoad);
	}
}
