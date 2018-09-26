using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CheckPoint : MonoBehaviour {

    public static Vector3 checkPos;
    public static bool isCheck =false;

	// Use this for initialization
	void Start () {
        checkPos = SphereController.startPos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
