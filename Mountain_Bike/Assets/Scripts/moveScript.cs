using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody m_rigidBody;
    public float moveSpeed;
    public float leanConstant;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        float direction = checkDirection();
        m_rigidBody.MovePosition(transform.position+transform.right*direction*Time.fixedDeltaTime*moveSpeed);
        //Quaternion deltaRotation = Quaternion.Euler(new Vector3(0,0,direction) * Time.fixedDeltaTime*leanConstant);
        transform.eulerAngles = new Vector3(0,0,direction*leanConstant* Time.fixedDeltaTime);
        
    }
    float checkDirection(){
        float direction = Input.GetAxis("Horizontal");
        return direction;
    }
}
