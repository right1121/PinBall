using UnityEngine;
using System.Collections;

public class FripperController : MonoBehaviour {
    //HingiJointコンポーネントを入れる
    private HingeJoint myHingeJoynt;

    //初期の傾き
    private float defaultAnge = 20;

    //はじいた時の傾き
    private float flickAngle = -20;

	// Use this for initialization
	void Start () {
            //HingeJointコンポーネント取得
            this.myHingeJoynt = GetComponent<HingeJoint>();

            //フリッパーの傾きを設定
            SetAngle(this.defaultAnge);
	
	}
	
	// Update is called once per frame
	void Update () {
            
            //左矢印キーを押したとき左フリッパーを動かす
            if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
            {
                SetAngle (this.flickAngle);
            }
            //右矢印キーを押したとき右フリッパーを動かす
            if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
            {
                SetAngle (this.flickAngle);
            }
            //矢印キーが離されたときフリッパーをもとに戻す
            if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
            {
            SetAngle(this.defaultAnge);
            }
	
	}

    //フリッパーの傾きを設定
    public void SetAngle (float angle){
        JointSpring jointSpr = this.myHingeJoynt.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoynt.spring = jointSpr;

    }

}
