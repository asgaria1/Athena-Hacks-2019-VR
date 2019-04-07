using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CloudTimer : MonoBehaviour
{
    private int buffer;

    [SerializeField]
    public GameObject cloud;

    [SerializeField]
    public GameObject c;

    [SerializeField]
    public float timeLeft = 5f;

    private string wholesomeLevel;
    private string storyVal;
    private Dictionary<string, string[]> dict = new Dictionary<string, string[]>();

    // Start is called before the first frame update
    void Start()
    {
        // Set every SINGLE WORD FOR EVERY COMBINATION
        // Dict has 20 keys for each combination with an array for the value
        // positive arrays have 21(7*3) entries and negative have 9(3*3)
        SetStoryOne();
        SetStoryTwo();
        SetStoryThree();
        SetStoryFour();

        //create a buffer so all clouds dont change at the
        //same time and calculate the time left until change
        buffer = Random.Range(0, 10);
        timeLeft = timeLeft + buffer;
        
        //storyval is a 3 number string
        //0 - STORY NUMBER
        //1 - SENTENCE NUMBER
        //2 - BOOLEAN FOR NEGATIVE OR POSITIVE
        //  ->> 0 = false (negative)
        //  ->> 1 = true (positive)

        //wholesome is  string that is either 0 or 1 for negativity
        storyVal = storyVal + wholesomeLevel;
        Text tochange = c.GetComponent<Text>();

        //Gets word based on neg or pos since neg has 9 and pos has 21
        //different random ranges.
        //Then sets text to result
        tochange.text = getWord(wholesomeLevel); 
    }

    // Update is called once per frame
    void Update()
    {
        //time counts down
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            //deactivate, wait 1 second with coroutine then reactivate with new word
            cloud.SetActive(false);
            Invoke("DelayedActive", 1f);
            


        }



    }
    void DelayedActive()
    {
        cloud.SetActive(true);
        timeLeft = 5f + buffer;
        Text tochange = c.GetComponent<Text>();
        tochange.text = getWord(wholesomeLevel);
    }

    void getStoryVal( string annieVal)
    {
        storyVal = annieVal;
    }

    string getWord( string wholesome)
    {
        if (wholesomeLevel == "1") { return dict[storyVal][Random.Range(0, 20)]; }
        else { return dict[storyVal][Random.Range(0, 8)]; }
    }

    void SetStoryOne()
    {
        string[] arrayboi111 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("111", arrayboi111);

        string[] arrayboi110 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("110", arrayboi110);

        string[] arrayboi121 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("121", arrayboi121);

        string[] arrayboi120 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("120", arrayboi120);

        string[] arrayboi131 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("131", arrayboi131);

        string[] arrayboi130 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("130", arrayboi130);

        string[] arrayboi141 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("141", arrayboi141);

        string[] arrayboi140 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("140", arrayboi140);

        string[] arrayboi151 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("151", arrayboi151);

        string[] arrayboi150 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("150", arrayboi150);

    }

    void SetStoryTwo()
    {
        string[] arrayboi211 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("211", arrayboi211);

        string[] arrayboi210 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("210", arrayboi210);

        string[] arrayboi221 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("221", arrayboi221);

        string[] arrayboi220 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("220", arrayboi220);

        string[] arrayboi231 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("231", arrayboi231);

        string[] arrayboi230 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("230", arrayboi230);

        string[] arrayboi241 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("241", arrayboi241);

        string[] arrayboi240 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("240", arrayboi240);

        string[] arrayboi251 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("251", arrayboi251);

        string[] arrayboi250 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("250", arrayboi250);
    }

    void SetStoryThree()
    {
        string[] arrayboi311 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("311", arrayboi311);

        string[] arrayboi310 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("310", arrayboi310);

        string[] arrayboi321 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("321", arrayboi321);

        string[] arrayboi320 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("320", arrayboi320);

        string[] arrayboi331 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("331", arrayboi331);

        string[] arrayboi330 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("330", arrayboi330);

        string[] arrayboi341 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("341", arrayboi341);

        string[] arrayboi340 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("340", arrayboi340);

        string[] arrayboi351 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("351", arrayboi351);

        string[] arrayboi350 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("350", arrayboi350);

    }

    void SetStoryFour()
    {
        string[] arrayboi411 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("411", arrayboi411);

        string[] arrayboi410 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("410", arrayboi410);

        string[] arrayboi421 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("421", arrayboi421);

        string[] arrayboi420 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("420", arrayboi420);

        string[] arrayboi431 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("431", arrayboi431);

        string[] arrayboi430 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("430", arrayboi430);

        string[] arrayboi441 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("441", arrayboi441);

        string[] arrayboi440 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("440", arrayboi440);

        string[] arrayboi451 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7", "word 8",
            "word 9", "word 10", "word 11", "word 12",
            "word 13", "word 14", "word 15", "word 16",
            "word 17", "word 18", "word 19", "word 20",
            "word 21"};
        dict.Add("451", arrayboi451);

        string[] arrayboi450 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("450", arrayboi450);

    }
	
	public void setStoryVal( string annieVal)
    {
        storyVal = annieVal;
    }
}
