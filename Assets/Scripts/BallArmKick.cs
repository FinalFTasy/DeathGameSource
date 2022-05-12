using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallArmKick : MonoBehaviour
{
    public GameObject ballArmKick;
    public Animator animator;
    public AudioSource source;
    public int counter;
    private float timer = 2f;
    // Start is called before the first frame update
    void Awake()
    {
        //ballArmKick.SetActive(false);
        ballArmKick.transform.position = new Vector3(0,-30f,0);
        source = GetComponent<AudioSource>();
        source.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerManager.ChangeCamera)
        {
            if (Input.GetMouseButton(0))
            {
                AudioPlay();
                ballArmKick.transform.localPosition = new Vector3(0,3f,6f);
                ballArmKick.transform.localRotation = new Quaternion(-7,131,98,1);
                animator.SetBool("isBool", true);
            }
            /*else if (Input.GetMouseButton(0))
            {
                
            }*/
            if (Input.GetMouseButtonUp(0))
            {
                ballArmKick.transform.position = new Vector3(0,-30f,0);
                animator.SetBool("isBool", false);
            }
        }
    }
    
    public void AudioPlay()
    {
        timer += Time.frameCount;
        source.Play();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Creator")
        {
            //Debug.Log("1");
            //Destroy(collision.gameObject);
            counter++;
            if (counter >= 4)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
