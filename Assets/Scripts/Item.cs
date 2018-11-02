using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    // トリガーとの接触時に呼び出される
    void OnTriggerEnter(Collider hit) {
        if (hit.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}
