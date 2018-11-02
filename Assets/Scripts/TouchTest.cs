using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OnTouchDown())
        {
            Debug.Log("タップされました");
        }
    }

    //スマホ向け そのオブジェクトがタッチされていたらtrue（マルチタップ対応）
    bool OnTouchDown()
    {
        //// タッチ情報をコピー
        //Touch t = Input.GetTouch(i);
        //TouchInfo info = AppUtil.GetTouch();
        //if (info == TouchInfo.Began)
        //{
        //    // タッチ開始
        //}
        //else if (t.phase == TouchPhase.Moved)
        //{
        //    // タッチ移動
        //}
        //else if (t.phase == TouchPhase.Ended)
        //{
        //    // タッチ終了
        //}


        // タッチされているとき
        if (0 < Input.touchCount)
        {
            // タッチされている指の数だけ処理
            for (int i = 0; i < Input.touchCount; i++)
            {
                // タッチ情報をコピー
                Touch t = Input.GetTouch(i);
                TouchInfo info = AppUtil.GetTouch();
                // タッチしたときかどうか
                if (info == TouchInfo.Began)
                {
                    Debug.Log("touch!");
                    //タッチした位置からRayを飛ばす
                    Ray ray = Camera.main.ScreenPointToRay(t.position);
                    RaycastHit hit = new RaycastHit();
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Rayを飛ばしてあたったオブジェクトが自分自身だったら
                        if (hit.collider.gameObject == this.gameObject)
                        {
                            return true;
                        }
                    }
                }
            }
        }
        return false; //タッチされてなかったらfalse
    }
}