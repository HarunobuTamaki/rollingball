using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //カメラが回らないよう回転しないように固定
        transform.Rotate(0, Input.GetAxis("Horizontal2"), 0);

        GameObject CameraParent = Camera.main.transform.parent.gameObject;
        CameraParent.transform.Rotate(0, 0, 0);
	}
}
