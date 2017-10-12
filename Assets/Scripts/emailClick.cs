using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emailClick : MonoBehaviour {

    private GameObject DataController;

    private void Start()
    {
        DataController = GameObject.Find("DataController");
    }

    private void OnMouseDown()
    {
        logicScript Script = DataController.GetComponent<logicScript>();
        Script.showPatientInfo = true;
        this.gameObject.SetActive(false);
    }
}
