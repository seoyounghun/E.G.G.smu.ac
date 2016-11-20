using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameUI : MonoBehaviour {


	public Text txtScore;
	private int totScore=3;

	// Use this for initialization
	void Start () {

		DispScore (0);
	
	}



	public void DispScore (int score)
	{
		totScore += score;
		txtScore.text = "enemy1 / "   + totScore.ToString ();


	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
