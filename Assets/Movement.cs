using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Vector3 place;
    public Vector3 newPosition;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && transform.position.y <= 4.5)
        {
            transform.Translate(new Vector3(0, 1, 0));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            transform.Translate(new Vector3(0, -1, 0));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            transform.Translate(new Vector3(1, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            transform.Translate(new Vector3(-1, 0, 0));
        }
    }
}
