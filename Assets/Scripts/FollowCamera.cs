using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    //this things position (camera) should be the same as the car's position
    void Update (){
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
    
}
