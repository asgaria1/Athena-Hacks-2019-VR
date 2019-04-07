using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sadlib : MonoBehaviour
{
	List<string> storylines;
	
    // Start is called before the first frame update
    void Start()
    {
		storylines = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
	
	public void addLine(string line) {
		Debug.Log("added Line");
		storylines.Add(line);
		Debug.Log(line);
	}
}
