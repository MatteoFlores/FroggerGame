using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour {

    public Vector3 car;

    // Use this for initialization
    void Start () { 
        car = transform.position;
        //Debug.Log(car + "car position in position script");
	}
	
	// Update is called once per frame
	void Update () {
        car = transform.position;
        
	}
}
