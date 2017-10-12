using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSpriteOnClick : MonoBehaviour
{
    private GameObject DataController;
    public GameObject button;
    public Sprite Up;
    public Sprite Down;

    // Use this for initialization
    void Start()
    {
        DataController = GameObject.Find("DataController");
        GameObject button = gameObject;
    }

    void OnMouseDown()
    {
        button.GetComponent<SpriteRenderer>().sprite = Down;
    }

    void OnMouseUp()
    {
        button.GetComponent<SpriteRenderer>().sprite = Up;
        logicScript Script = DataController.GetComponent<logicScript>();
        Script.showPatientInfo = false;
    }
}