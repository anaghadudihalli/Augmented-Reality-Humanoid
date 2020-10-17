using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBalls : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform startPosRot;
	public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	Vector3 posAdd;

     if (Input.GetMouseButton(0)) {
     	
     	posAdd = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.06f, 0.06f), Random.Range(-0.06f, 0.06f));

     	Instantiate(ball, startPosRot.position+posAdd, startPosRot.rotation);
     }   
    }
}
