using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Activatingcanvas : MonoBehaviour {

    public GameObject menu;
    private bool isShowing = false;

    private void Start()
    {
        menu.SetActive(isShowing);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
        }
    }

}
