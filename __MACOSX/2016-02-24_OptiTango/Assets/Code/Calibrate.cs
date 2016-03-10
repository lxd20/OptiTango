using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calibrate : MonoBehaviour {
	public Text calibrationText;
	Vector3 angleOffset = Vector3.zero;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.localEulerAngles += angleOffset;
		angleOffset = Vector3.zero;
		calibrationText.text = string.Format ("Rotation:\nX: {0}\nY: {1}\nZ: {2}", transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z);
	}

	public void angleUp() {
		angleOffset += new Vector3 (1, 0, 0);
	}
	public void angleDown() {
		angleOffset += new Vector3 (-1, 0, 0);
	}
	public void angleLeft() {
		angleOffset += new Vector3 (0, -1, 0);
	}
	public void angleRight() {
		angleOffset += new Vector3 (0, 1, 0);
	}
	public void angleClockwise() {
		angleOffset += new Vector3 (0, 0, 1);
	}
	public void angleCounterClockwise() {
		angleOffset += new Vector3 (0, 0, -1);
	}
}
