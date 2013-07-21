using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	float mMoveSpeed = 0.1f;
	float mJumpSpeed = 0.8f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(mMoveSpeed, 0, 0);
		}
		else if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(-mMoveSpeed, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			transform.Translate(0, mJumpSpeed, 0);
		}
	}
}
