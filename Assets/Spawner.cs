using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject spawnedObj;
    public int numObjs = 3;
    public Vector3 wheretheyspawn;
    public Vector3[] positionObjs = new Vector3[20]; //max objects spawned allowed
    public int minRange = 0;
    public int maxRange = 1;
    // Use this for initialization

	void Start () {
        Vector3 tempCar;

        Hashtable ht = new Hashtable();
        

        for (int i = 0; i<numObjs ; i+= 1 )
        {
             
            tempCar = new Vector3((float)Random.Range(-4, 4) + 0.5f, Random.Range(minRange,maxRange+1) +.5f , 0f);
            
            while (ht.ContainsValue(tempCar))
            {
                tempCar = new Vector3((float)Random.Range(-4, 4) + 0.5f, Random.Range(minRange, maxRange) + .5f, 0f);
            }
            ht.Add(i, tempCar);
            Instantiate(spawnedObj, tempCar, Quaternion.identity);

        }

        /*while (three.transform.position == one.transform.position || three.transform.position == two.transform.position)
         {
             three.transform.position = new Vector3((float)Random.Range(-4, 4) + 0.5f, -2.5f, 0f);
         }
         while (two.transform.position == one.transform.position || two.transform.position == three.transform.position)
         {
             two.transform.position = new Vector3((float)Random.Range(-4, 4) + 0.5f, -2.5f, 0f);
         }*/
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
