using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other){
    	GameObject self = GetComponent<GameObject>();
    	Debug.Log("Found Key");
    	self.SetActive(false);
    	//CaravanMove c = other.GetComponent<CaravanMove>();
    	
    	
    	
    }

}
