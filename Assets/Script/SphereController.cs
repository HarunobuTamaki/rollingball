using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {

    public float speed = 10.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    public static Vector3 startPos;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}

    // Update is called once per frame
    void Update(){
        //プレイヤーを移動させる
        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Trigger")
        {
            transform.position = CheckPoint.checkPos;
        }

        if (other.gameObject.tag == "ScoreCapsule")
        {
            GameManager.score += 10;
            Destroy(other.gameObject);
        }

    }
    

}
