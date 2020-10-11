using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
using TMPro;

public class animationScript : MonoBehaviour
{
    public GameObject buttonObject;
    public Animator anim;
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        buttonObject = GameObject.Find("buttonToSpeak");
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);   
        anim.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");
        Debug.Log("*********");
        Debug.Log("*********");
        anim.SetBool("isTalking", true);
        source.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
