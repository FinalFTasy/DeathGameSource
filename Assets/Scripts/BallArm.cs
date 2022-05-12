using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallArm : MonoBehaviour
{
    public float rotateSpeed = 200f;
    float xRotation = 0f;
  
    public Transform ballPoint;
    
    public GameObject ballArm;//球杆

    void Start()
    {
        ballArm.transform.localPosition = new Vector3(0,-30f,0);
        //ballArm.SetActive(false);
    }
    
    void Update()
    {
        if (PlayerManager.ChangeCamera)
        {
            if (Input.GetMouseButtonDown(0))
            {
            
                //ballArm.SetActive(true);
                //ballArm.transform.Translate();
                ballArm.transform.position= new Vector3(ballPoint.position.x+10.3f, 4f, ballPoint.position.z);
            }
            else if (Input.GetMouseButton(0))
            {
                float mouseY = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
                xRotation -= mouseY;
                xRotation = Mathf.Clamp(xRotation, -180f, 180f);
                var ballTran = ballPoint.transform.position;
                ballPoint.Rotate(new Vector3(0,ballTran.y,0),mouseY);
            }

            if (Input.GetMouseButtonUp(0))
            {
                ballArm.transform.localPosition = new Vector3(0,-30f,0);
                //ballArm.SetActive(false);
            }
        }
    }
}


