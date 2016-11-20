using UnityEngine;
using System.Collections;

public class AttackCtrl : MonoBehaviour {

	private GameUI gameUI;

    public int enemy1num = 3;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "ENEMY")  //충돌한 대상이 적1태그를 가지고 있는 녀석이면
        {
            Destroy(coll.gameObject);   //그 충돌한 대상을 없앤다.
            enemy1num -= 1;  //적1 의 총 수 감소
			gameUI.DispScore(-1);

        }
        else if (coll.collider.tag == "ENEMY2")
                {
            if(enemy1num==0)
            {
                Destroy(coll.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }

        }


    }


	void OnGui ()
	{
		GUI.color = Color.black;
		string label = "남은 적 수" +enemy1num;

		GUI.Label (new Rect (0,0, 100, 40), label);



	}




	// Use this for initialization
	void Start () {

		gameUI = GameObject.Find ("GameUI").GetComponent<GameUI> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
