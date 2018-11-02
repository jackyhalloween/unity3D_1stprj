using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public UnityEngine.UI.Text scoreLabel;
    public UnityEngine.UI.Text timeLabel;

    public GameObject winnerLabelObject;
    public GameObject restartButton;

    private Time t;

    // Update is called once per frame
    void Update ()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        timeLabel.text = Time.deltaTime.ToString();
        //seconds = (int)totalTime;
        //timerText.text = seconds.ToString();

        if (count == 0)
        {
            winnerLabelObject.SetActive(true);
            restartButton.SetActive(true);
        }
    }
}
