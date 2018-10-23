using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {

	// Use this for initialization
	void Start () {
  
    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetTouch(0).position.x > 0.0f)
        {
            GetComponent<Animator>().SetTrigger("Die");
        }
        else
        {
            GetComponent<Animator>().SetTrigger("Attack");
        }
    }
}
