using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OverManager : MonoBehaviour {

    public Text itemScore;
    public Text timeScore;
    public Text totalScore;
    
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
        itemScore.GetComponent<Text>().text =
            GameManager.score.ToString();
        timeScore.GetComponent<Text>().text =
            Mathf.FloorToInt(GameManager.timeScore).ToString();
        totalScore.GetComponent<Text>().text =
            (Mathf.FloorToInt(GameManager.timeScore) + GameManager.score).ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("TitleScene");
        }
	}
}
