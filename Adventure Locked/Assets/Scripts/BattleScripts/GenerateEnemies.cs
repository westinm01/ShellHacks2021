using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
	public float enemyNum;
	public GameObject Lizard;
	public GameObject Eye;
	public GameObject Ghost;
	public GameObject Plant;
	private float maxLevel;
    // Start is called before the first frame update
    void Start()
    {
    	maxLevel=1;
        enemyNum=Random.Range(1,6);
        Debug.Log(enemyNum);
        for(float i =0; i<enemyNum;i++){
        	GenerateEnemy(i);
        }
        //After this generation, then fill in each enemy's stats

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
    	float enemy=Random.Range(1,5); //chooses the specific enemy type
    	GameObject en;
    	switch (enemy){
    		case 1:
    			en=Instantiate(Eye, pos, Quaternion.identity);
    			break;
    		case 2:
    			en=Instantiate(Ghost, pos, Quaternion.identity);
    			break;
    		case 3:
    			en=Instantiate(Lizard, pos, Quaternion.identity);
    			break;
    		default:
    			en=Instantiate(Plant, pos, Quaternion.identity);
    			break;
    	}
    	Enemy enemyScript=en.GetComponent<Enemy>();//This gets the script
    	enemyScript.setLevel(maxLevel);
    }
}
