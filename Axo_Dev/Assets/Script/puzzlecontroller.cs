using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzlecontroller : MonoBehaviour
{
   public GameObject target1, target1black, target2, target2black;

   Vector2 target1Pos, target2Pos;

    public void Start(){
        target1Pos = target1.transform.position;
        target2Pos = target2.transform.position;
    }


    //Target1
    public void Dragtarget1(){
        target1.transform.position = Input.mousePosition;
   }

    public void Droptarget1(){
    float Distance = Vector3.Distance(target1.transform.position, target1black.transform.position);
    
       if(Distance<30){
           target1.transform.position = target1black.transform.position;
       } 
   }

   //Target2
    public void Dragtarget2(){
        target2.transform.position = Input.mousePosition;
   }

    public void Droptarget2(){
    float Distance = Vector3.Distance(target2.transform.position, target2black.transform.position);
    
       if(Distance<30){
           target2.transform.position = target2black.transform.position;
       } 
   }

	//private void OnTriggerEnter2D (Collider2D collider){
		//target1.transform.position = target1black.transform.position;
		//Dragtarget1();
	//}


}
