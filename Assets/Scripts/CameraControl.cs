using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;
    // Start is called before the first frame update
    void Start()
    {
        cameraOne.enabled = true;
        cameraTwo.enabled = false;
        GameObject.Find("PlayerBall").GetComponent<PlayerManager>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && cameraOne.enabled == true)
        {
            cameraTwo.enabled = true;
            cameraOne.enabled = false;
            PlayerManager.ChangeCamera = true;
            //GameObject.Find("Main Camera").GetComponent<PlayerController>().enabled=false;
            //GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
            GameObject.Find("PlayerBall").GetComponent<PlayerManager>().enabled = true;


        }
        else if (Input.GetMouseButtonDown(1) && cameraTwo.enabled == true)
        {
            cameraOne.enabled = true;
            cameraTwo.enabled = false;
            PlayerManager.ChangeCamera = false;
            //GameObject.Find("Main Camera").GetComponent<PlayerController>().enabled=true;
            //GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = true;
            GameObject.Find("PlayerBall").GetComponent<PlayerManager>().enabled = false;
        }
    }
}
