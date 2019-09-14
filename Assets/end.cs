using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour {

    public GameObject prefabFrog;
    
    int endFrogs = 0;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {


        GameObject[] enemies = GameObject.FindGameObjectsWithTag("endFrog");
        Vector3 here = transform.position;
        if (!(transform.position.x == .5 && transform.position.y == -4.5)) // dont instantiate if at start
        {
            Instantiate(prefabFrog, here, Quaternion.identity); //instantiates an endfrog
            endFrogs += 1;
            ScoreScript.scoreVal += 1;
        }
        this.transform.position = new Vector2(0.5f, -4.5f); //returns to begining

        
        if (endFrogs == 8)
        {

            foreach (GameObject endFrog in enemies)
                GameObject.Destroy(endFrog);
            Debug.Log("win");
        }
        Debug.Log(endFrogs);
    }
    // Use this for initialization
    void Start () {

       
    }
	
	// Update is called once per frame
	void Update () {
		//if (transform.position.y =)
	}
}
