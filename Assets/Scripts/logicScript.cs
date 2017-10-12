using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicScript : MonoBehaviour {

    public bool showPatientInfo = false;

    public GameObject sprCompWindow;
    public GameObject emailSprite;
    public GameObject ageObject;
    public GameObject genderObject;
    public GameObject conditionObject;
    public GameObject notesObject;

    private GameObject DataController;

    // Use this for initialization
    void Start ()
    {
        DataController = GameObject.Find("DataController");
    }

    // Update is called once per frame
    void Update ()
    {
        if (showPatientInfo == true)
        {
            sprCompWindow.SetActive(true);
            ageObject.SetActive(true);
            genderObject.SetActive(true);
            conditionObject.SetActive(true);
            notesObject.SetActive(true);
            
        }

        if (showPatientInfo == false)
        {
            sprCompWindow.SetActive(false);
            ageObject.SetActive(false);
            genderObject.SetActive(false);
            conditionObject.SetActive(false);
            notesObject.SetActive(false);
            emailSprite.SetActive(true);

            //Change Patient info
            loadData Script = DataController.GetComponent<loadData>();
            Script.loadGameData();
            Script.showPatientInfo();

        }
    }
}
