using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneCtrl : MonoBehaviour
{

	// Use this for initialization
	public void MainBtClicked ()
    {
        SceneManager.LoadScene("stageselect1");
	
	}
	public void Stage1of1BtClicked ()
	{
		SceneManager.LoadScene("stage1_1");

	}
	public void Stage1of2BtClicked ()
	{
		SceneManager.LoadScene("stage2");

	}

}
