using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalManager : MonoBehaviour {

    public Text goalText;

	// Use this for initialization
	void Start () {
        goalText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine("GoalManage");
            goalText.enabled = true;
        }
    }

    IEnumerator GoalManage()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("OverScene") ;

    }

}
