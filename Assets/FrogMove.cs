using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMove : MonoBehaviour {
    public GameObject[] endFrogs = new GameObject[maxCars];
    public Vector3[] pos;
    public const int maxCars = 81;
    Position[] positionEndFrog = new Position[maxCars];
    private bool poop = false;
    // Use this for initialization
    void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        poop = true;
        endFrogs = GameObject.FindGameObjectsWithTag("endFrog");
        for (int i = 0; i < endFrogs.Length; i++)
        {
            positionEndFrog[i] = endFrogs[i].GetComponent<Position>();
        }
        for (int i = 0; i < positionEndFrog.Length; i++)
        {
            
            //if (transform.position == positionEndFrog[i].car)
            //if (positionEndFrog[i] != null)
                //Debug.Log("yes");
            if (positionEndFrog[i] != null && (transform.position.y == positionEndFrog[i].car.y - 1 && transform.position.x == positionEndFrog[i].car.x))
            {
                poop = false;
                break;
            }
            
        }
        if (poop == true && Input.GetKeyDown(KeyCode.UpArrow) == true && transform.position.y <= 3.5)
            transform.Translate(new Vector3(0, 1, 0));


        /* if (Input.GetKeyDown(KeyCode.UpArrow) == true && transform.position.y <= 3.5 && (transform.position.y != pos.y-1 || transform.position.x != pos.x))
     {
         transform.Translate(new Vector3(0, 1, 0));
     }
*/
        if (Input.GetKeyDown(KeyCode.DownArrow) == true && transform.position.y >= -3.5)
        {
            transform.Translate(new Vector3(0, -1, 0));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true && transform.position.x <= 2.5)
        {
            transform.Translate(new Vector3(1, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true && transform.position.x >= -2.5)
        {
            transform.Translate(new Vector3(-1, 0, 0));
        }
    }
}
