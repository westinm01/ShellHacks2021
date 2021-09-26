using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update

    public float chance;
    public float deltaTime;
    void Start(){
    	chance=100f;
    }
    void Update(){
    	deltaTime+=1;
    }
    void OnTriggerEnter2D(Collider2D other){

    	CaravanMove c = other.GetComponent<CaravanMove>();
    	c.SaveCaravan();
    	if(deltaTime>=100){
    		chance=Random.Range(1,100);
    	}
    	Debug.Log("Collided!" + chance);
    	if(chance<4){
    		SceneManager.LoadScene(1);
    	}
    	
    }
}
