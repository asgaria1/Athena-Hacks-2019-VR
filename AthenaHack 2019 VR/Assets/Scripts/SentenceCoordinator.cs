using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentenceCoordinator : MonoBehaviour
{
	//0 = Toddler/Child, 1 = Young Adult, 2 = Adult, 3 = Old 
	public int lifeStage = 0;
	
	public float waitingSeconds = 20f;
	public float timeLeft = 20f;
	
	public GameObject cloudSet;
	public GameObject sentTextObj;
	
	int numberSentences;
	int currSent = 0;
	
	string[] childSentence = {
		"This is tory 1 sentence 1",
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
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0) {
			//switch the sentence to the next sentence
			Text tochange = sentTextObj.GetComponent<Text>();
			tochange.text = allSentences[lifeStage][currSent];
			ChangeWordClouds(lifeStage, currSent);
			
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
	
	void ChangeWordClouds(int stor, int sent) {
		//send Ari's script a new key
		string newStory = (stor+1).ToString();
		newStory = newStory + (sent+1).ToString();
		cloudSet.GetComponent<CloudTimer>().setStoryVal(newStory);
		Debug.Log(newStory);
	}
}
