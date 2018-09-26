using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    float seconds =0;
    int minute=0;
    public static int score = 0;
    public static float timeScore=240;

    public Text scoreText;
    public Text timerText;
    public Text checkText;

	// Use this for initialization
	void Start () {
        checkText.enabled =false;
	}
	
	// Update is called once per frame
	void Update () {
        seconds += Time.deltaTime;
        timeScore -= Time.deltaTime;

        if (seconds >=60 )
        {
            minute++;
            seconds -= 60;
            
        }

        scoreText.GetComponent<Text>().text =
            string.Format("score:"+"{0:D4}",score);
        timerText.GetComponent<Text>().text =
            string.Format("{0:D2}" + ":"+"{1:F2}", minute, seconds);
        if(CheckPoint.isCheck)
        {
            StartCoroutine("EnableText");
        }
        Debug.Log(CheckPoint.isCheck);
    }

    IEnumerator EnableText()
    {
        checkText.enabled = true;
        yield return new WaitForSeconds(5.0f);
        checkText.enabled = false;
        CheckPoint.isCheck =false; 
    }
}
