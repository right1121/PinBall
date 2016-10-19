using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    //スコアを格納する変数
    private int score = 0;

    //スコアを表示するテキスト
    private GameObject scoreText;

    //tagの名前
    private string tagName;

    // Use this for initialization
    void Start() {

        this.scoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update() {

        this.scoreText.GetComponent<Text>().text = score.ToString();
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other) {

        //タグの名前を取得
        tagName = other.transform.tag;

        //タグの名前ごとにスコアを設定
        if (tagName == "SmallStarTag") {
            //小さい星
            score += 5;
        }
        else if (tagName == "LargeStarTag") {
            //大きい星
            score += 10;
        }
        else if (tagName == "SmallCloudTag") {
            //小さい雲
            score += 20;
        }
        else if (tagName == "LargeCloudTag") {
            //大きい雲
            score += 30;
        }
    }
}