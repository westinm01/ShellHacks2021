using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 cameraOffset;
    public float followSpeed = 8f;
    public float xMin = -300;
    Vector3 velocity = Vector3.zero;
    void Start(){
    	transform.position=target.position;
    }
    void Update(){
    	Vector3 targetPos=target.position + cameraOffset;
    	Vector3 clampedPos = new Vector3(Mathf.Clamp(targetPos.x,-22, float.MaxValue), targetPos.y, -10);
    	Vector3 smoothPos = Vector3.SmoothDamp(transform.position, clampedPos, ref velocity, followSpeed * Time.fixedDeltaTime);
    	transform.position = smoothPos;
    	
    }
}
