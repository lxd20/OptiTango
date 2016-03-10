using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {
//	Rigidbody rigid;
	// Use this for initialization
	void Start () {
//		rigid = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
//		rigid.AddForce (new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")));
		Vector3 cameraPos = GameObject.Find ("Cam").transform.position;
		//cameraPos.x *= -1;
		transform.LookAt (cameraPos);
	}
}
