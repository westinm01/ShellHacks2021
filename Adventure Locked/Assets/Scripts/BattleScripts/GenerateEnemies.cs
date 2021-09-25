using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
	public float enemyNum;
	public GameObject Lizard;
	public GameObject Eye;
	public GameObject Ghost;
    // Start is called before the first frame update
    void Start()
    {
        enemyNum=Random.Range(1,6);
        Debug.Log(enemyNum);
        for(float i =0; i<enemyNum;i++){
        	GenerateEnemy(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GenerateEnemy(float i){
    	Vector3 pos;
    	switch (i){
    		case 0:
    			pos=new Vector3(5f,-1f,0f);
    		break;
    		case 1:
    			pos=new Vector3(3f,-3f,0f);
    		break;
    		case 2: 
    			pos = new Vector3(2f, 0f, 0f);
    		break;
    		case 3:
    			pos=new Vector3(7f,1f,0f);
    		break;
    		default:
    			pos=new Vector3(6f,-4f,0f);
    			break;
    	}
    	float enemy=Random.Range(1,4);
    	switch (enemy){
    		case 1:
    			Instantiate(Eye, pos, Quaternion.identity);
    			break;
    		case 2:
    			Instantiate(Ghost, pos, Quaternion.identity);
    			break;
    		case 3:
    			Instantiate(Lizard, pos, Quaternion.identity);
    			break;
    	}
    	
    }
}
