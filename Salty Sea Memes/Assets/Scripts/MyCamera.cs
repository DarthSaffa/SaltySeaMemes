using UnityEngine;
using System.Collections;

public class MyCamera : MonoBehaviour {

	Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = transform; 
	}
	
	// Update is called once per frame
	void Update () {

		//We want to stop the camera from rotating
		myTransform.rotation = Quaternion.Euler(0,0,0);

		//Camera needs a constant z position
		myTransform.position = new Vector3 (myTransform.position.x, myTransform.position.y, -10);

	}
}
