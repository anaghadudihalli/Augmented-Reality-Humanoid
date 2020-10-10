using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
using TMPro;

public class animationScript : MonoBehaviour
{
    public GameObject buttonObject;
    // Start is called before the first frame update
    void Start()
    {
        buttonObject = GameObject.Find("buttonToSpeak");
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);   
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
