using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

	public void loadLevel(string name)
	{
		Debug.Log("Level load requested for:" + name);
	}

	public void quitRequest()
	{
		Debug.Log("I want to quit");
	}

}
