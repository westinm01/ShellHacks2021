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
	public GameObject Mole;
	public GameObject [] enemies;
	private float maxLevel;
	private int index;
    // Start is called before the first frame update
    void Start()
    {
    	index=0;
    	maxLevel=findMaxLevel();
        enemyNum=Random.Range(1,6);
        enemies = new GameObject [(int)enemyNum];
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
    	float enemy=Random.Range(1,6); //chooses the specific enemy type
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
    		case 4:
    			en=Instantiate(Mole, pos, Quaternion.identity);
    		break;
    		default:
    			en=Instantiate(Plant, pos, Quaternion.identity);
    			break;
    	}
    	Enemy enemyScript=en.GetComponent<Enemy>();//This gets the script
    	enemyScript.setLevel(maxLevel);
    	enemies[index]=en;
    	index++;
    }
    public float findMaxLevel(){
    	GameObject n = GameObject.FindGameObjectWithTag("Nate");
    	GameObject s = GameObject.FindGameObjectWithTag("Silver");
    	GameObject c = GameObject.FindGameObjectWithTag("Clyde");
    	GameObject k = GameObject.FindGameObjectWithTag("Kris");
    	Hero nate = n.GetComponent<Hero>();
    	Hero silver = s.GetComponent<Hero>();
    	Hero clyde = c.GetComponent<Hero>();
    	Hero kris = k.GetComponent<Hero>();
    	float nateL=nate.level;
    	float silverL=silver.level;
    	float clydeL= clyde.level;
    	float krisL = kris.level;
    	float maxL=nateL;
    	if(silverL>maxL){
    		maxL=silverL;
    	}
    	if(clydeL>maxL){
    		maxL=clydeL;
    	}
    	if(krisL>maxL){
    		maxL=krisL;
    	}
    	return maxL;
    }
}
