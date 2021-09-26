using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class HeroData
{
    
	public float level;
	public float health;
	public float currHealth;
	public float damage;
    public HeroData(Hero hero){
    	level=hero.level;
    	health=hero.health;
    	currHealth=hero.currHealth;
    	damage=hero.damage;
    }
}
