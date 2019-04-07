using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CloudTimer : MonoBehaviour
{
    [SerializeField]
    public int buffer;
    [SerializeField]
    public GameObject cloud;
    public GameObject c;
    [SerializeField]
    public float timeLeft = 5f;
    public Dictionary<string, string> dict = new Dictionary<string, string>();
    //public GameObject[] posWords;

    // Start is called before the first frame update
    void Start()
    {
        buffer = Random.Range(0, 10);
        timeLeft = timeLeft + buffer;
        dict.Add("111", "Test");

    }

    // Update is called once per frame
    void Update()
    {
        //time counts down
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            cloud.SetActive(false);
            //disable current cloud and continue through the array
            //ExecuteAfterTime(1);
            Invoke("DelayedActive", 1f);
            


        }



    }
    void DelayedActive()
    {
        
        //change text
        //
        cloud.SetActive(true);
        timeLeft = 5f + buffer;
        Text tochange = c.GetComponent<Text>();
        tochange.text = dict["111"];
    }

    /*IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        //TO DOOOOOO
        //PLS DO IT ARI
        //change text!!


    }*/
}
