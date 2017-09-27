using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class gameLogic : MonoBehaviour {

    Text ageText;
    Text genderText;
    Text conditionText;
    Text notesText;

    public string preCondition;
    public string age;
    public string notes;
    public string gender;

    private int patientNum;

    private string gameDataFileName = "PatientInfoData.json";

    private void LoadGameData()
    {
        //point to JSON file
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);
        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            //GameData loadedData = JsonUtility.FromJson<GameData>(dataAsJson);

            GameData[] patient = JsonHelper.FromJson<GameData>(dataAsJson);

            patientNum = Random.Range(0,2);

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

    private void showPatientInfo()
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
        LoadGameData();
        
        //Pair Text variables with Unity object UI Text Objects
        ageText = GameObject.Find("Age").GetComponent<Text>();
        genderText = GameObject.Find("Gender").GetComponent<Text>();
        conditionText = GameObject.Find("Condition").GetComponent<Text>();
        notesText = GameObject.Find("Notes").GetComponent<Text>();

        //Show patient info on the computer window
        showPatientInfo();
        

	}
}
