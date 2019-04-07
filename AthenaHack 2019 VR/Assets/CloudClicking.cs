using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CloudClicking : MonoBehaviour
{
	Transform cameraTransform = null;
	public GameObject sentenceCoord;
	public GameObject sKeeper;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	void Awake() {
		cameraTransform = GameObject.FindWithTag("MainCamera").transform;
	}
	
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Vector3 rayDirection = cameraTransform.TransformDirection(Vector3.forward);
			Vector3 rayStart = cameraTransform.position + rayDirection;
			Debug.DrawRay(rayStart, rayDirection * 300.0f, Color.green);
			if(Physics.Raycast(rayStart, rayDirection, out hit, 300.0f)) {
				if (hit.collider.tag == "Cloud") {
					GameObject collidedCloud = hit.collider.gameObject;
					
					GameObject collidedCloudObj = collidedCloud.transform.GetChild(0).gameObject;
					Debug.Log(collidedCloudObj);
					TextMeshPro collidedCloudTMP = collidedCloudObj.GetComponent<TextMeshPro>();
					string cloudText = collidedCloudTMP.text;
					sKeeper.GetComponent<Sadlib>().addLine(cloudText);
					sentenceCoord.GetComponent<SentenceCoordinator>().resetTime();
				}
			}
			/*RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 100.0f)) {
				Debug.Log("Click");
			}*/
		}
		
		
    }
}
