using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSpriteOnClick : MonoBehaviour {

    public GameObject button;
    public Sprite Up;
    public Sprite Down;

    // Use this for initialization
    void Start ()
    {
        GameObject button = gameObject;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            button.GetComponent<SpriteRenderer>().sprite = Down;
        }
        else
            button.GetComponent<SpriteRenderer>().sprite = Up;
    }
}
