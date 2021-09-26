using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    // Start is called before the first frame update
    public float health;
    public float currHealth;
    public float level;
    public float healthInc;
    public float damage;
    public float damageInc;
    public string firstName;

    void Start()
    {
        LoadHero();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelUp(){
    	damage+=damageInc;
    	health+=healthInc;
    	level+=1;
    }

    public void Attack(GameObject enemy){

    }
    public void SaveHero(){
    	SaveSystem.SaveHero(this);
    }
    public void LoadHero(){
    	HeroData data=SaveSystem.LoadHero(this);
    	if(data==null){
    		level=1;

    	}
    	damage=data.damage;
    	level=data.level;
    	health=data.health;
    	currHealth=data.currHealth;
    }
}
