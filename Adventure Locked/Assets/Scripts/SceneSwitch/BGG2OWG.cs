using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGG2OWG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	saveHeroData();

        if(Input.GetKey(KeyCode.Space)){
        	SceneManager.LoadScene(0);
        }
    }

    public void saveHeroData(){
    	//need to get heroes by tag and save each one
    	GameObject n = GameObject.FindGameObjectWithTag("Nate");
    	GameObject s = GameObject.FindGameObjectWithTag("Silver");
    	GameObject c = GameObject.FindGameObjectWithTag("Clyde");
    	GameObject k = GameObject.FindGameObjectWithTag("Kris");
    	Hero nate = n.GetComponent<Hero>();
    	Hero silver = s.GetComponent<Hero>();
    	Hero clyde = c.GetComponent<Hero>();
    	Hero kris = k.GetComponent<Hero>();
    	nate.SaveHero();
    	silver.SaveHero();
    	clyde.SaveHero();
    	kris.SaveHero();

    }
}
