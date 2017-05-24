using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryAcceptReject : MonoBehaviour {

    public BackpackBehaviour Bpbehavior;
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Bpbehavior.AcceptingItems == true)
            text.text = "Accepting Items";
        else
            text.text = "Not Accepting Items";
	}
}
