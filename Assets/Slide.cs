using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour {

    float moveTime = 0.8f;
    GameObject[] Cars;
    GameObject Car;
    public Vector3 resetRight;
    private void Awake()
    {
        Cars = GameObject.FindGameObjectsWithTag("car");
        
    }

        // Use this for initialization
        void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        moveTime -= Time.deltaTime;
        if (moveTime <= 0)
        {
            //Debug.Log("move");
            transform.Translate(new Vector3(-1, 0, 0));
            moveTime = 0.8f;
        }
        if (transform.position.x <= -4.5)
            transform.position = new Vector3 (resetRight.x, transform.position.y,transform.position.z);
        //Destroy(GetComponent<SpriteRenderer>());
        if (transform.position.x <= -5.5)
        {
            
            //Instantiate(car)
            // Destroy(gameObject);
            //Instantiate(Cars, new Vector3(3.5f, -2.5f, 0f), Quaternion.identity);
        }
    }
}
