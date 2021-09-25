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

    void Start()
    {
        
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
}
