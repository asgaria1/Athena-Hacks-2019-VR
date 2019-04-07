
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManagement : MonoBehaviour
{
    public GameObject[] clouds;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeWordClouds(int stor, int sent)
    {
        for (int i = 0; i < clouds.Length; i++)
        {
            string newStory = (stor + 1).ToString();
            newStory = newStory + (sent + 1).ToString();
            clouds[i].GetComponent<CloudTimer>().SetStoryVal(newStory);
        }

    }
}
