using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
    Vector3 frogStart;
    public const int maxCars = 81;
    Vector3 frog;
    GameObject[] Cars = new GameObject[maxCars];
    Position[] positionCar = new Position[maxCars];
    GameObject[] Logs = new GameObject[maxCars];

    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(transform.position);
        
        Logs = GameObject.FindGameObjectsWithTag("log");
        Cars = GameObject.FindGameObjectsWithTag("car");
        for (int i = 0; i < Cars.Length; i++)
        {
            positionCar[i] = Cars[i].GetComponent<Position>();
        }
        //Debug.Log(Cars.Length);
        frog = transform.position;
        for (int i = 0; i < Cars.Length; i++)
        {
            if (frog == positionCar[i].car)
            {
                transform.position = new Vector3(0.5f, -4.5f, 0);//restarts to starting position
            }
        }
        /* if (frog == positionCar[i].car)
     {
        transform.position = new Vector3(0.5f, -4.5f, 0);//restarts to starting position
     }
     */
        bool onlog = false;
        // Debug.Log(Logs[i].transform.position);
        if (frog.y >= 0.5 && frog.y <= 1.5)
            {
            
                for (int i = 0; i < Logs.Length; i++)
                {
                    if ( frog == Logs[i].transform.position)
                    {
                     transform.parent = Logs[i].transform;
                    onlog = true;
                    }
                    Debug.Log("restart");
                }
                if(!onlog)
                   { 
                    //transform.parent = null;
                    transform.position = new Vector3(0.5f, -4.5f, 0); 
                   }
            }  
            if (!onlog)
            transform.parent = null;
    }
}
