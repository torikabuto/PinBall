using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//Scoreを表示するテキストを取得
	private GameObject scoreText;

	//sumを0で初期化する
	private int score = 0;
	private int sum = 0;

	// Use this for initialization
	void Start () {
		//シーン中のScoreTextオブジェクトを取得
		this.scoreText = GameObject.Find ("ScoreText");	
	}

	// Update is called once per frame
	void Update () {
				

	}
	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {

			//SmallStarにボールが当った際Score+10
		if (other.gameObject.tag == "SmallStarTag") {
			score = 10;
		}
			//LargeStarにボールが当たった際Score+20
			else if (other.gameObject.tag == "LargeStarTag") {
			score = 20;
		}
			//SmallCloudにボールが当たった際Score+15
			else if (other.gameObject.tag == "SmallCloudTag") {
			score = 15;
		}
			//LargeCloudにボールが当たった際Score+30
			else if (other.gameObject.tag == "LargeCloudTag") {
			score = 30;
		} 
		//障害物以外のものにボールが当たった際加点なし
		else {
			score = 0;
		}
		sum += score;
		//スコアを表示
		this.scoreText.GetComponent<Text> ().text = "Score:" + sum;
	}
}
