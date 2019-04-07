using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CloudTimer : MonoBehaviour
{
    private int buffer;

    [SerializeField]
    public GameObject cloud;

    [SerializeField]
    public GameObject c;

    [SerializeField]
    public float timeLeft = 10f;

    public string wholesomeLevel;
    public string storyVal;
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
        //Debug.Log(storyVal);
        //storyVal = storyVal + wholesomeLevel;
        storyVal = "11" + wholesomeLevel;
        Debug.Log(storyVal);
        TextMeshPro tochange = c.GetComponent<TextMeshPro>();

        //Gets word based on neg or pos since neg has 9 and pos has 21
        //different random ranges.
        //Then sets text to result
        tochange.text = GetWord(wholesomeLevel);
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
        TextMeshPro tochange = c.GetComponent<TextMeshPro>();
        tochange.text = GetWord(wholesomeLevel);
    }

    void GetStoryVal(string annieVal)
    {
        //Debug.Log(annieVal);
        storyVal = annieVal;
    }

    string GetWord(string wholesome)
    {
        if (wholesomeLevel == "1") { return dict[storyVal][Random.Range(0, 20)]; }
        else { return dict[storyVal][Random.Range(0, 8)]; }
    }

    void SetStoryOne()
    {
        string[] arrayboi111 = { "friends you trust", "friends who have similar interests as you",
            "friends who do well in academics", "friends you can look up to", "friends you feel comfortable talking to",
            "friends who support you", "a diverse group of friends", "helpful teachers",
            "good study habits", "one really good friend", "other women", "people in your classes",
            "women with an interest in STEM", "people who empower you", "staff and trusted adults"};
        dict.Add("111", arrayboi111);

        string[] arrayboi110 = { "nobody and nothing", "friends that make bad decisions", "friends that like to gossip",
            "friends that ignore you", "friends that don't take opportunities" };
        dict.Add("110", arrayboi110);

        string[] arrayboi121 = { "attend your favorite club",
            "play soccer", "practice the piano", "go to your job at Target",
            "go to band practice", "go for a run", "go to tutoring", "take a nap",
            "study", "hang out with your friends", "go to ballet practice", "play video games",
            "take your dog for a walk", "do your chores", "do your homework"};
        dict.Add("121", arrayboi121);

        string[] arrayboi120 = { "spend a long time watching TV",
            "stress about classes", "doubts about friends", "play video games until 3am",
            "watch inappropriate rap videos" };
        dict.Add("120", arrayboi120);

        string[] arrayboi131 = { "lots of very good food",
            "a nice house", "a puppy", "a kitty",
            "a loving grandparent", "parents that make time for you", "a chicken for a pet", "a very large library",
            "wealthy parents that can give you what you need", "a lot of electronics and technology", "a big happy family", "sleeping in a nice, warm bed",
            "a sibling that is there for you when you need it", "parent who love and support you", "parents who support extracurriculars by attending games/performances"};
        dict.Add("131", arrayboi131);

        string[] arrayboi130 = { "your annoying cousin larry",
            "a sibling that picks on you all the time", "frozen food", "late homework",
            "parents that work all the time"};
        dict.Add("130", arrayboi130);
    }

    void SetStoryTwo()
    {
        string[] arrayboi211 = { "hang out with friends",
            "go vacationing", "attend hackathons", "play music",
            "make music", "play video games", "instagram aesthetic photos", "cook great meals",
            "read books", "exercise", "watch youtube videos", "plan cute outfits",
            "practice makeup", "study for long hours", "draw art"};
        dict.Add("211", arrayboi211);

        string[] arrayboi210 = { "stress about your future",
            "feel like you aren't good enough", "let others boss you around", "lounge around",
            "feel sick"};
        dict.Add("210", arrayboi210);

        string[] arrayboi221 = { "EVERY MAJOR IS IMPORTANT",
            "EVERY MAJOR IS IMPORTANT", "EVERY MAJOR IS IMPORTANT", "EVERY MAJOR IS IMPORTANT",
            "EVERY MAJOR IS IMPORTANT", "EVERY MAJOR IS IMPORTANT", "EVERY MAJOR IS IMPORTANT", "EVERY MAJOR IS IMPORTANT",
            "EVERY MAJOR IS IMPORTANT", "EVERY MAJOR IS IMPORTANT", "EVERY MAJOR IS IMPORTANT", "EVERY MAJOR IS IMPORTANT",
            "EVERY MAJOR IS IMPORTANT", "EVERY MAJOR IS IMPORTANT"};
        dict.Add("221", arrayboi221);

        /*string[] arrayboi220 = { "word 1",
            "word 2", "word 3", "word 4",
            "word 5", "word 6", "word 7",
            "word 8", "word 9" };
        dict.Add("220", arrayboi220);*/

        string[] arrayboi231 = { "attend a hackathon",
            "get an internship", "meet new people", "add a minor or double major",
            "go to a resume builder workshop", "go to a keynote speaker event", "get in touch with recruiters on Linkedin", "join a club",
            "join greek life", "join a service organization", "become president of a club", "become a teachers assistant",
            "get a part time job", "do work study", "study abroad"};
        dict.Add("231", arrayboi231);

        string[] arrayboi230 = { "drop out of college",
            "go into debt", "don't do your homework and assignments", "lose faith in yourself",
            "don't seek help when you need it" };
        dict.Add("230", arrayboi230);

        string[] arrayboi241 = { "take some time off to relax",
            "go to grad school", "try to start your own company", "get a job",
            "get a job at a big company", "go on Linkedin and do some networking", "meet new people", "find a way to make a difference",
            "find a place to live and settle down", "find a place to live and settle down", "settle down and have children", "get a pet",
            "actively look for a job", "look around for a job you will enjoy", "continue with school to get an additional degree"};
        dict.Add("241", arrayboi241);

        string[] arrayboi240 = { "get a job you are not happy with",
            "live with your parents for many years after", "passively look for a job", "lose faith in yourself",
            "get imposer syndrome"};
        dict.Add("240", arrayboi240);

    }

    void SetStoryThree()
    {
        string[] arrayboi311 = { "gain confidence",
            "get brave", "try new things", "grow",
            "sprout", "gain confidence", "grow", "try your very best",
            "mellow out", "work hard", "get inspired", "form a dream",
            "understand you are important", "understand you matter", "feel great"};
        dict.Add("311", arrayboi311);

        string[] arrayboi310 = { "get imposter syndrome",
            "feel tired", "feel existential", "grow more fears",
            "get lazy"};
        dict.Add("310", arrayboi310);

        string[] arrayboi321 = { "eating healthy",
            "running laps", "swimming", "painting",
            "higher positions in your career", "hackathons", "higher education", "self care",
            "skin care", "makeup", "video gaming", "reading books",
            "making music", "listening to music", "vlogging"};
        dict.Add("321", arrayboi321);

        string[] arrayboi320 = { "working too much",
            "feeling like you're not good enough", "feeling constantly tired", "fearing death",
            "a funeral" };
        dict.Add("320", arrayboi320);

        string[] arrayboi331 = { "Children",
            "Pets", "A new best friend", "A mentor",
            "A long lost family member", "A new job opportunity", "A famous person", "Your all time favorite hero",
            "A large sum of money", "A new job position", "A powerful woman", "A significant other",
            "A possible promotion", "A new house", "A new car"};
        dict.Add("331", arrayboi331);

        string[] arrayboi330 = { "Bad Influences",
            "Obstacles", "Negative people", "Stress",
            "A break up" };
        dict.Add("330", arrayboi330);

        string[] arrayboi341 = { "decide to change to a different field",
            "have a kid", "get a promotion", "become the Manager",
            "become the CEO", "have a great relationship with your coworkers", "continue to work on your networking skills", "transfer to a job you enjoy more",
            "transfer to a job you enjoy more", "become the leader of an important project", "attend a meeting with important people", "go on a buisness trip",
            "quit this job to start your own buisness", "become a keynote speaker", "become an inspiration for all women"};
        dict.Add("341", arrayboi341);

        string[] arrayboi340 = { "quit your job",
            "are unhappy but are scared to quit", "are still not respected by people with higher positions of power", "have been demoted",
            "get fired"};
        dict.Add("340", arrayboi340);

        /*string[] arrayboi351 = { "word 1",
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
        dict.Add("350", arrayboi350);*/

    }

    void SetStoryFour()
    {
        string[] arrayboi411 = { "adopt a pet",
            "adopt a child", "attend your wildrens wedding", "buy a farm",
            "buy a new house", "donate money to a charity", "invest in the stock market", "try new hobbies",
            "go back for a degree", "try to be enice to everyone you meet", "get daily haircuts", "drink exclusively kale juice",
            "travel", "go on a cruise", "hug your grandchildren"};
        dict.Add("411", arrayboi411);
        /*
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
        dict.Add("440", arrayboi440);*/

        /*string[] arrayboi451 = { "word 1",
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
        dict.Add("450", arrayboi450);*/
    }

    public void SetStoryVal(string annieVal)
    {
        //Debug.Log(annieVal);
        storyVal = annieVal;
    }
}
