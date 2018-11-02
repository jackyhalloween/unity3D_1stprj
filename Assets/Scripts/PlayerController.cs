using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // 速度の規定値を設定
    public float speed = 10;

    // プレイヤーが動くごとに呼び出される処理
    void FixedUpdate() {
        // 入力値を取得
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // このゲームオブジェクトのrigitBodyコンポーネントの取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        // rigitbodyにx,y軸の力を加える。
        rigidbody.AddForce(x*speed, 0, z*speed);

    }
}
