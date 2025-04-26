using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Transform p1;
    public Transform p2; 
    public float speed=10;
    void Start(){
        transform.position = p1.position; 
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, p2.position, speed*Time.deltaTime);
        if(transform.position==p2.position){
            transform.position = p1.position; 
        }
    }
}
