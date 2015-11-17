using UnityEngine;
using System.Collections;

public class CoordinateMap : MonoBehaviour {
//	Vector3 PlayerCoordinate;
//	Vector3 Obtacle1Coordinate;
	Vector3 [] Coordinates;

	// Use this for initialization
	void Start () {
		Coordinates = new Vector3[Tags.MaxID];
		Coordinates[Tags.PlayerID] = GameObject.FindGameObjectWithTag (Tags.Player).transform.position;
		Coordinates[Tags.Obtacle1ID] = GameObject.FindGameObjectWithTag (Tags.Obstacle).transform.position;
//		PlayerCoordinate = GameObject.FindGameObjectWithTag (Tags.Player).transform.position;
//		Obtacle1Coordinate = GameObject.FindGameObjectWithTag (Tags.Obstacle).transform.position;
	}

	public void updateCoordinate(int flag, Vector3 currentPosition){

		switch (flag) {
		case Tags.PlayerID:
			Coordinates[Tags.PlayerID] = currentPosition;
			break;
		}

	}

	// Update is called once per frame
	void Update () {
		Debug.Log (Coordinates[Tags.PlayerID]);
	}
}
