﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SentenceCoordinator : MonoBehaviour
{
	//0 = Toddler/Child, 1 = Young Adult, 2 = Adult, 3 = Old 
	public int lifeStage = 0;
	
	public float waitingSeconds = 25f;
	public float timeLeft = 25f;
	
	public GameObject cloudSet;
	public GameObject sentTextObj;
	
	int numberSentences;
	int currSent = 0;
	
	string[] childSentence = {
		"As a child you attend school. There, you surround yourself with _____.",
		"Everyday after school you _____.",
		"At home, your life consists of _____."
	};
	
	string[] yaSentence = {
		"In your developing years, you most often _____.",
		"You decide to go to college. You pick _____ as your major.",
		"Freshman year has come and gone. In your second year of college you _____.",
		"After your four years at college you _____."
	};
	
	string[] adultSentence = {
		"Finally gaining more independence, you begin to _____ as an adolescent adult.",
		"As a mature adult, you got into _____.",
		"_____ enter(s) your life.",
		"After a couple years at your job you _____."
	};
	
	string[] oldSentence = {
		"Many, many years later, after a long life, in your elderly years you decide to _____."
	};

	string[][] allSentences;
	
    // Start is called before the first frame update
    void Start()
    {
        allSentences = new string[4][];
		allSentences[0] = childSentence;
		allSentences[1] = yaSentence;
		allSentences[2] = adultSentence;
		allSentences[3] = oldSentence;
    }

    // Update is called once per frame
    void Update()
    {
		numberSentences = allSentences[lifeStage].Length;
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0) {
			//switch the sentence to the next sentence
			TextMeshPro tochange = sentTextObj.GetComponent<TextMeshPro>();
			tochange.text = allSentences[lifeStage][currSent];
			ChangeWordSet(lifeStage, currSent);
			
			currSent++;
			if (currSent >= numberSentences) {
				lifeStage++;
				timeLeft = waitingSeconds; //reset the timer
			}
		}
		
    }
	
	IEnumerator waiter(int seconds) {
		yield return new WaitForSeconds(seconds);
	}
	
	void ChangeWordSet(int stor, int sent) {
		//send to cloud
		cloudSet.GetComponent<CloudManagement>().ChangeWordClouds(stor, sent);
		
	}
}
