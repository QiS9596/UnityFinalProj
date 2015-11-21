using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {
	public GameObject player;
	Vector3 rotation;
	float rotateSpeed;
	// Use this for initialization
	void Start () {
		rotation = 	Random.onUnitSphere;
		rotateSpeed = Random.Range (0.2f,3.0f);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (rotation * rotateSpeed);
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == Tags.Player) {
			Debug.Log ("On Collision Enter");
		}
	}
}
