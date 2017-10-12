using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class loadData : MonoBehaviour {

    Text ageText;
    Text genderText;
    Text conditionText;
    Text notesText;

    public string preCondition;
    public string age;
    public string notes;
    public string gender;

    public GameObject ageObject;
    public GameObject genderObject;
    public GameObject conditionObject;
    public GameObject notesObject;

    public int patientNum;

    private string gameDataFileName = "PatientInfoData.json";

    public void loadGameData()
    {
        //point to JSON file
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);
        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            //GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);

            GameData[] patient = JsonHelper.FromJson<GameData>(dataAsJson);

            patientNum = Random.Range(0,5);

            age = patient[patientNum].age;
            preCondition = patient[patientNum].preCondition;
            gender = patient[patientNum].gender;
            notes = patient[patientNum].notes;
        }
        else
        {
            Debug.Log("Cannot load data");
        }
    }

    public void showPatientInfo()
    {
        //change text fields on the Text Unity UI objects
        ageText.text = age;
        genderText.text = gender;
        conditionText.text = preCondition;
        notesText.text = notes;
    }

	void Start ()
    {
        //Load data from JSON
        loadGameData();
        
        //Pair Text variables with Unity object UI Text Objects
        ageText = ageObject.GetComponent<Text>();
        genderText = genderObject.GetComponent<Text>();
        conditionText = conditionObject.GetComponent<Text>();
        notesText = notesObject.GetComponent<Text>();

        //Show patient info on the computer window
        showPatientInfo();       
	}
}
