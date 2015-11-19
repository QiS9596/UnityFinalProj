using UnityEngine;
using System.Collections;

public class Blackhole : MonoBehaviour {
	public float gravity = 12000;
	public GameObject player;
	const float maxBoundary = 170;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerStay(Collider other){
		other.gameObject.GetComponent<Rigidbody>().AddForce (other.transform.position * gravity * -1.0f/Mathf.Pow(other.transform.position.magnitude,2));

	}
	void OnCollisionEnter(Collision other){
		Debug.Log ("Colllision entered");
		if (other.collider.gameObject.tag == Tags.Player)
			Destroy (player);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
