using System.Collections;
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
		"This is story 1 sentence 1",
		"This is story 2 sentence 2"
	};
	
	string[] yaSentence = {
		"This is story 2 sentence 1",
		"This is story 2 sentence 2"
	};
	
	string[] adultSentence = {
		"This is story 3 sentence 1",
		"This is story 3 sentence 2"
	};
	
	string[] oldSentence = {
		"This is story 4 sentence 1",
		"This is story 4 sentence 2"
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
