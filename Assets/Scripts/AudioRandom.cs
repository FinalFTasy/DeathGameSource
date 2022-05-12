using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRandom : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip otherClip1;
    public AudioClip otherClip2;
    public AudioClip otherClip3;
    public float musicVolume;
    public float randomNum;
    public int state;

    // Start is called before the first frame update
    void Start()
    {
        musicVolume = 0.5f;
        randomPlay();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = musicVolume;
        if (Input.GetMouseButton(0))
        {
            if ((state == 1 && !audioSource.isPlaying) || (state == 2 && !audioSource.isPlaying) || (state == 3 && !audioSource.isPlaying))
            {
                randomPlay();
            }
        }
    }
    void randomPlay()
    {
        randomNum = Random.Range(1.0f, 4.0f);
        if(randomNum >= 1.0f && randomNum < 2.0f)
        {
            state = 1;
            audioSource.clip = otherClip1;
            audioSource.Play();
        }
        else if(randomNum >= 2.0f && randomNum < 3.0f)
        {
            state = 2;
            audioSource.clip = otherClip2;
            audioSource.Play();
        }
        else if (randomNum >= 3.0f && randomNum < 4.0f)
        {
            state = 3;
            audioSource.clip = otherClip3;
            audioSource.Play();
        }
    }
}