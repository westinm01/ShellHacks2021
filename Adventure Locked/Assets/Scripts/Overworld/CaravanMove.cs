﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaravanMove : MonoBehaviour
{
	Vector2 input;
    bool isMoving = false;
    Vector3 startPos;
    Vector3 endPos;
    float t;
   	bool currentDir;
    private SpriteRenderer sr;
    public float walkSpeed = 3f;
	/*public float movementSpeed=8;
	public float JumpForce=6;
	//private Animator _animator;
   
	private Rigidbody2D _rigidbody;
    private SpriteRenderer sr;*/
    // Start is called before the first frame update
    void Start()
    {
        //_rigidbody = GetComponent<Rigidbody2D>();
       
        sr=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isMoving)
        {
            input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if (Mathf.Abs(input.x) > Mathf.Abs(input.y)){
                input.y = 0;
            }
            else{
                input.x = 0;
            }
            
            if(input!=Vector2.zero){
                if(input.x < 0)
                {
                	sr.flipX=false;
                    currentDir = false;
                }
                if(input.x > 0)
                {
                	sr.flipX=true;
                    currentDir = true;
                }
            	StartCoroutine(Move(transform));
        	}
        }
    	/*var movement = Input.GetAxis();
        //_animator.setFloat("Speed", movement);
        transform.position += new Vector3(movement,0,0) * Time.deltaTime * movementSpeed;

        /*if(Input.GetButtonDown("Vertical") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f){
        	_rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }*/

    }

    public IEnumerator Move(Transform entity)
    {
        isMoving = true;
        startPos = entity.position;
        t = 0;

        endPos = new Vector3(startPos.x + System.Math.Sign(input.x), startPos.y + System.Math.Sign(input.y), startPos.z);

        while (t < 1f)
        {
            t += Time.deltaTime * walkSpeed;
            entity.position = Vector3.Lerp(startPos, endPos, t);
            yield return null;
        }

        isMoving = false;
        yield return 0;
    }
}
