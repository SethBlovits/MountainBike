using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileMover : MonoBehaviour
{

    // Update is called once per frame
   
    public float moveSpeedScale;
    void Update()
    {
        //rb.MovePosition(transform.position+transform.forward*Time.deltaTime*moveSpeedScale);
        transform.position+=transform.forward*Time.deltaTime*moveSpeedScale;
              
    }
    void OnCollisionEnter(Collision collision) {
        //Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "KillWall"){
            Destroy(gameObject);
        }        
    }

}
