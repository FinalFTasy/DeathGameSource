using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] AudioClips;
    // Start is called before the first frame update
    public AudioSource source;
    private float timer = 0f;
    public float speed = 200f;
    private int clipsIndex = 0;
    
    //private  Audio
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.ChangeCamera)
        {
            ClipPlay();
        }
    }
 
    public void ClipPlay()
    {
        timer += Time.frameCount;
        if (timer % speed == 0 && !source.clip)
        {
            var clip = AudioClips[clipsIndex%AudioClips.Length];
            source.clip = clip;
            source.Play();
            clipsIndex++;
        }
    }
}
