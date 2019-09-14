using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slides : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x <= -4.5)
            transform.position = new Vector3(4.5f, -2.5f, 0);

    }
}
