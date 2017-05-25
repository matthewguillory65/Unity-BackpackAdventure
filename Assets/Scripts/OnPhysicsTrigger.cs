using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnPhysicsTrigger : MonoBehaviour {

    [System.Serializable]
    public class TriggerEnter : UnityEvent { }
    public TriggerEnter onTriggerEnter;
    [System.Serializable]
    public class TriggerExit : UnityEvent { }
    public TriggerExit onTriggerExit;
    [System.Serializable]
    public class TriggerEnterItem : UnityEvent<Item> { }
    public TriggerEnterItem onTriggerEnterItem;


    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
    }
}
