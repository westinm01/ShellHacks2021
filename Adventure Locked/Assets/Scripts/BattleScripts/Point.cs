using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public GameObject battle;
    private int index;
    private Transform myTransform;
    public void Start()
    {
        //Assign battle by tag.
        GenerateEnemies t = battle.GetComponent<GenerateEnemies>();
        //Vector3 position;
        myTransform=GetComponent<Transform>();
        index=0;
       // position= new Vector3(target.transform.position.x-2,target.transform.position.y,target.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

    	GenerateEnemies t = battle.GetComponent<GenerateEnemies>();
    	target=t.enemies[index];
    	Vector3 position;
    	if(Input.GetKeyDown("up")){
    		index++;
    		if(index>=t.enemies.Length){
    			index=t.enemies.Length-1;
    		}
    		Debug.Log("UP");
    	}
    	if(Input.GetKeyDown("down")){
    		index--;
    		if(index<=0){
    			index=0;
    		}
    		Debug.Log("DOWN");
    	}
        target=t.enemies[index];
        position= new Vector3(target.transform.position.x-2,target.transform.position.y,target.transform.position.z-1);
        myTransform.position=position;

    }
}
