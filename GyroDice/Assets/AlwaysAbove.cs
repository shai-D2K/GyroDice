using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysAbove : MonoBehaviour {

    public GameObject cube;
    public float height = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(cube.transform.position.x, cube.transform.position.y + height, cube.transform.position.z);

        transform.LookAt(cube.transform);
    }
}
