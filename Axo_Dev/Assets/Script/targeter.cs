using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targeter : MonoBehaviour
{


    void OnCollisionStay2D(Collision2D other) {
        if(other.collider.gameObject.tag == "controllers"){
            other.collider.GetComponent<controllers>().collision = true;
            if(other.collider.GetComponent<controllers>().dragging){
                other.collider.gameObject.transform.position = transform.position;
            }
        }
    }

     void OnCollisionExit(Collision other) {
         other.collider.GetComponent<controllers>().collision = false;
        
    }
}
