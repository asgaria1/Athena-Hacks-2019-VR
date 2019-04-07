using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SentenceCoordinator : MonoBehaviour
{
    //0 = Toddler/Child, 1 = Young Adult, 2 = Adult, 3 = Old 
    public int lifeStage = 0;
	int currSent = 0;


    public float waitingSeconds = 40f;
    public float timeLeft = 40f;

    public GameObject cloudSet;
    public GameObject sentTextObj;
	public GameObject[] darkClouds;

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
        "Finally gaining more independence, you began to _____ as an adolescent adult.",
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
        TextMeshPro tochange = sentTextObj.GetComponent<TextMeshPro>();
        tochange.text = allSentences[0][0];
        ChangeWordSet(0, 0);
		ChangeStuff();
		StartCoroutine(Timer());
    }
	
	IEnumerator Timer() {
		yield return new WaitForSeconds(waitingSeconds);
		ChangeStuff();
	}
	
	void ChangeStuff() {
		Debug.Log(lifeStage + " // " + currSent);
		int numberSentences = allSentences[lifeStage].Length;
        if (lifeStage < 3)
        {
            //switch the sentence to the next sentence
            TextMeshPro tochange = sentTextObj.GetComponent<TextMeshPro>();
            tochange.text = allSentences[lifeStage][currSent];
            ChangeWordSet(lifeStage, currSent);

            currSent++;
            if (currSent >= numberSentences)
            {
                lifeStage++;
                timeLeft = waitingSeconds; //reset the timer
                currSent = 0;
            }
        }
        else
        { 
            if (lifeStage == 3)       
            {
                //remove all the dark clouds
                for (int i = 0; i < darkClouds.Length; i++)
                {
                    darkClouds[i].SetActive(false);
                }
                TextMeshPro tochange = sentTextObj.GetComponent<TextMeshPro>();
                tochange.text = allSentences[lifeStage][currSent];
                ChangeWordSet(lifeStage, currSent);
                lifeStage++;
                SceneManager.LoadScene("AriScene");
            }
            
                
            
		}
		StartCoroutine(Timer());
	}
	

    void ChangeWordSet(int stor, int sent)
    {
        //send to cloud
        //Debug.Log(stor);
        cloudSet.GetComponent<CloudManagement>().ChangeWordClouds(stor, sent);

    }
	
	public void resetTime (GameObject cloudToReset) {
		StopCoroutine(Timer());
		ChangeStuff();
	}
}

