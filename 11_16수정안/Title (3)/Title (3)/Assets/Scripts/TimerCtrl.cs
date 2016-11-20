using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TimerCtrl : MonoBehaviour {

	public Text timer;
	const int Fulltime=10;

	int counter;

	// Use this for initialization
	void Start () {

		StartCoroutine (TimeCounter ());

	
	}
	
	// Update is called once per frame
	void Update () {
		


	}


	IEnumerator TimeCounter()
	{
		counter = Fulltime;

		while (counter > 0) {

			timer.text = "time" + counter + "s";

			yield return new WaitForSeconds (1.0f);
			counter--;



		}



	}

}
