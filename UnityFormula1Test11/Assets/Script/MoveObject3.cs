using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject3 : MonoBehaviour
{
    public Transform p1;
    public Transform p2;
    public Transform p3;
    Vector3 targetPos;  

    public float speed=10;
    void Start(){

        transform.position = p1.position; 
        targetPos = p2.position; 
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
        
        
        if(transform.position==p2.position){
            targetPos = p3.position;       
        }
        else if(transform.position==p3.position){
            transform.position =p1.position; 
            targetPos = p2.position; 
        }
    }
}