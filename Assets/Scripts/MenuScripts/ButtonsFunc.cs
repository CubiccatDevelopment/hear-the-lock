using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsFunc : MonoBehaviour {


	public void LoadLevelMenu(){
		SceneManager.LoadScene (1);
	}
	public void LoadMenu(){
		SceneManager.LoadScene (0);
	}
}
