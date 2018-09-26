using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckPoint1 : CheckPoint {
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            checkPos = new Vector3(-86, 1.3f, 255);
            isCheck = true;
        }
    }
}
