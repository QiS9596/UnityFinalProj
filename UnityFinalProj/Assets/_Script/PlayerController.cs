using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	float h,v;
	CoordinateMap map;
	Vector3 currentPosition;
	// Use this for initialization
	void Start () {
		currentPosition = new Vector3();
		map = GameObject.FindGameObjectWithTag (Tags.GameController).GetComponent<CoordinateMap> ();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");
		transform.Translate (h,v,0);
		currentPosition = transform.position;
		map.updateCoordinate (Tags.PlayerID, transform.position);
	}
}
