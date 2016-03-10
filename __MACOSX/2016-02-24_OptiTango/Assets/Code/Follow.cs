using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
	public Transform followee;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = followee.position;
	}
}
