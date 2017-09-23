using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour {

    public class insurePrompt //The pop-ups on the computer with patient information
    {
        public string preCondition; //Pre-existing conditions 

        public string gender; //Still up in the air for this one, but for now the patient's self-identified gender. Can also be n/a

        public string age;

        public string notes; //Notes placed by either doctor's or the company about the patient
    }

    Text age;
    Text gender;
    Text condition;
    Text notes;
    

	// Use this for initialization
	void Start ()
    {
        //Initialize FirstPrompt Class and add values
        insurePrompt FirstPrompt = new insurePrompt();
        FirstPrompt.preCondition = "This is a thing";
        FirstPrompt.gender = "no gender specified";
        FirstPrompt.age = "45";
        FirstPrompt.notes = "Notes go here";

        //Pair Text variables with Unity object UI Text Objects
        age = GameObject.Find("Age").GetComponent<Text>();
        gender = GameObject.Find("Gender").GetComponent<Text>();
        condition = GameObject.Find("Condition").GetComponent<Text>();
        notes = GameObject.Find("Notes").GetComponent<Text>();

        //Change text on screen to FirstPromt class values
        age.text = FirstPrompt.age;
        gender.text = FirstPrompt.gender;
        condition.text = FirstPrompt.preCondition;
        notes.text = FirstPrompt.notes;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
