using System.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform target;    // ターゲットへの参照
    private Vector3 offset;     // 相対参照

    // 起動時に一度だけ実施
    void Start() {
        offset = GetComponent<Transform>().position - target.position;
    }

	// Update is called once per frame
	void Update () {
        GetComponent<Transform>().position = target.position + offset;
	}
}
