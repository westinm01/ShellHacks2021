using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class CaravanData
{
    public float[] position;

    public CaravanData(CaravanMove caravan){
    	position=new float[3];
    	position[0] = caravan.transform.position.x;
    	position[1] = caravan.transform.position.y;
    	position[2] = caravan.transform.position.z;
    }
}
