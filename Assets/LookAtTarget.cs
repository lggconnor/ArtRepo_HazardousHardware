using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{

    //we want to get a reference to an object that the turret is going to track

    public GameObject targetToTrack;
    public bool shouldTrackTarget;
    public float trackingThreshold = 5f;

	//later we may want to have a threshold to represent the range that the turret is aware of for tracking. but not right now. 
	// Start is called before the first frame update
	void Start()
    {
        //we should make sure we are looking at the "player" here
        if (targetToTrack == null)
        {
            //targetToTrack = whatever static reference to the player game object the programmers have set up
        }
        Debug.Log("the game object we are tracking is: " + targetToTrack);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (targetToTrack.transform.position - this.gameObject.transform.position).magnitude;
        
        if ( distance > trackingThreshold) 
        {
            shouldTrackTarget = false;
        }
        else
        {
            shouldTrackTarget = true;
        }

        if (shouldTrackTarget)
        {
			this.transform.LookAt(targetToTrack.transform);
		}
        

		//we dont actually need or care about this it was an example debug log
        //Debug.Log("the game object distance from us is: " + (targetToTrack.transform.position - this.gameObject.transform.position).magnitude);

	}
}
