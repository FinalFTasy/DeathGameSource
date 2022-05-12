using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleManager : MonoBehaviour
{
    //public Transform BallTrans;
    public Transform family;
    public GameObject holeBall;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        //BallTrans = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.count == 0)
        {
            Time.timeScale = 0;
        }

        if (PlayerManager.flag == 0)
        {
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        /*if (collisionInfo.gameObject.tag == "Finish")
        {
            Time.timeScale = 0;
        }*/

        if (collisionInfo.gameObject.tag == "Finish")
        {
            holeBall = collisionInfo.collider.gameObject;
            var speed = holeBall.GetComponent<Rigidbody>().velocity;
            var curIndex = 5 - index;
            var nextTran = family.GetComponent<Hole>().holeTrans[curIndex].GetChild(0);
            
            holeBall.transform.position = nextTran.position;
            
            //holeBall
            //PlayerManager.count--;
        }
        else if (collisionInfo.gameObject.tag == "White")
        {
            holeBall = collisionInfo.collider.gameObject;
            var speed = holeBall.GetComponent<Rigidbody>().velocity;
            var curIndex = 5 - index;
            var nextTran = family.GetComponent<Hole>().holeTrans[curIndex].GetChild(0);
            
            holeBall.transform.position = nextTran.position;
            //PlayerManager.count--;
        }
        //Destroy(collisionInfo.gameObject);
    }
}
