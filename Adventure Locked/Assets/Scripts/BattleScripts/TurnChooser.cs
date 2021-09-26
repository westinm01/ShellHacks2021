using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnChooser : MonoBehaviour
{
    // Start is called before the first frame update
    private bool choosing;
    private bool battleDone;
    void Start()
    {
        choosing=true;
        battleDone=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(battleDone){
        	BGG2OWG b= GetComponent<BGG2OWG>();
        	b.LoadOW();
        }
    }
    void heroTurn(){
    	//This repeats for each hero!

    	while(choosing){		//while choosing a move
    		if(Input.GetKey("enter")){
    			choosing=false;
    			//record what key got selected.
    			
    		}
    		//2 options, attack or run
    		if(Input.GetKey("up")){
    			//highlight attack
    		}
    		if(Input.GetKey("down")){
    			//highlight run
    		}
    	}
    	/*if(run){
			attemptToRun();
    	}*/
    	//move pointer to first enemy
    	choosing=true;
    	while(choosing){
    		if(Input.GetKey("up")){
    			//move pointer up
    		}
    		if(Input.GetKey("down")){
    			//move pointer down
    		}
    		if(Input.GetKey("enter")){
    			choosing=false;
    			//this locks in the enemy chosen by pointer
    		}
    	}
    	//GetComponent<Point>.target; (where target is an enemy)
    	//hero.Attack(enemy);

    }
}
