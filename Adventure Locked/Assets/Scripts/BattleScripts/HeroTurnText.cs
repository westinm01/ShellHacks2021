using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroTurnText : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D myrigidbody;
    RectTransform myTransform;
    void Start()
    {
    	myTransform = GetComponent<RectTransform>();
    	myTransform.anchoredPosition = new Vector3(15,-8,0);
        myrigidbody=GetComponent<Rigidbody2D>();
        myrigidbody.velocity = new Vector2(0,800);
    }

    // Update is called once per frame
    void Update()
    {
        //if hero turn, call start.
    }
}
