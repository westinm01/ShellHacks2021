using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public float chance;
    void OnTriggerEnter2D(Collider2D other){
    	
    	chance=Random.Range(1,100);
    	Debug.Log("Collided!" + chance);
    	if(chance<4){
    		SceneManager.LoadScene(1);
    	}
    	
    }
}
