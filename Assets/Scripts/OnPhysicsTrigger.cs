using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnPhysicsTrigger : MonoBehaviour {

    [System.Serializable]
    public class OnTriggerEnter : UnityEvent { }
    public OnTriggerEnter onTriggerEnter;
    [System.Serializable]
    public class OnTriggerExit : UnityEvent { }
    public OnTriggerExit onTriggerExit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
