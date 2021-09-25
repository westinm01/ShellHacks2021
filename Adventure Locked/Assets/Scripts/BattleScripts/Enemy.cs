using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float health;
	public float currHealth;
	public float level;
	public float damage;
    // Start is called before the first frame update
    void Start()
    {
        //Battle Gets all hero levels, choose the largest.
        //Battle Sets all enemies to the largest level
        //
    }

    // Update is called once per frame
    void Update()
    {
        //if currHealth<=0, play death animation and disappear
    }

    public void setLevel(float maxLevel){
    	level=maxLevel + Random.Range(-2,2);
    	if(maxLevel<3){
    		level=1;
    		health=1;
    		currHealth=health;
    		damage=1;
    		return;
    	}
    	damage=level;
    	health=maxLevel/2+1;
    	currHealth=health;
    }
}
