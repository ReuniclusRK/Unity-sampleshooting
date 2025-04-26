using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	int score = 0;
	GameObject scoreText;
    GameObject gameOverText;

    //public void GameOver(){
        //this.gameOverText.GetComponent<Text>().text = "GameOver";
        //隕石が画面端のラインを超えたときにゲームオーバーと判定
        //画面下を超えたかどうかはRockControllerで判定している
    //}

	public void AddScore(){
		this.score += 10;
        //BulletContorollerから呼び出される
        //スコアの更新を担う
	}

	void Start () {
		this.scoreText = GameObject.Find ("Score");
   	//シーンビューに配置したUIのテキストを検索し、メンバ変数に保存
		//this.gameOverText = GameObject.Find("GameOver");
	}

	void Update () {
		scoreText.GetComponent<Text> ().text = "Score:" + score.ToString("D4");
	}
}