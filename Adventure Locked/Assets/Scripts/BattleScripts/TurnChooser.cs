using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnChooser : MonoBehaviour
{
    // Start is called before the first frame update
    private bool choosing;
    private bool battleDone;
    public Hero [] heroes;
    public GameObject nate;
    public GameObject kris;
    public GameObject clyde;
    public GameObject silver;
    public GameObject finger;

    void Start()
    {
        choosing=true;
        battleDone=false;
        heroes = new Hero[4];
        heroes[0]=nate.GetComponent<Hero>();
        heroes[1]=kris.GetComponent<Hero>();
        heroes[2]=clyde.GetComponent<Hero>();
        heroes[3]=silver.GetComponent<Hero>();
        heroTurn();
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
    	foreach(Hero hero in heroes){
    		//turn rendering off for pointer here
    	/*while(choosing){		//while choosing a move
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
    	}*/
    	/*if(run){
			attemptToRun();
    	}*/
    	//move pointer to first enemy
    	choosing=true;
    	while(choosing){
    		if(Input.GetKey("enter")){
    			choosing=false;
    			Debug.Log("CHOSEN");
    			//this locks in the enemy chosen by pointer
    		}
    	}
    	GameObject enemyObject = finger.GetComponent<Point>().target;
    	Enemy enemy=enemyObject.GetComponent<Enemy>();
    	hero.Attack(enemyObject);
    }
    	//GetComponent<Point>.target; (where target is an enemy)
    	//hero.Attack(enemy);

    }
}
