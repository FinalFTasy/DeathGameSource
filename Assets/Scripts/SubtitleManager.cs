using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SubtitleManager : MonoBehaviour
{
    public float start;
    public float string1;
    public float string2;
    public float string3;
    public float string4;
    public float string5;
    public float string6;



    private Text text;
    public List<string> st = new List<string>();
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(subtitle(start));
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    public IEnumerator subtitle(float timer)
    {
        yield return new WaitForSeconds(string1);

        text.text = st[index];
        index++;
        StartCoroutine(subtitle1(timer));
    }
    public IEnumerator subtitle1(float timer)
    {
        yield return new WaitForSeconds(string2);
        text.text = st[index];
        index++;
        StartCoroutine(subtitle2(timer));
    }
    public IEnumerator subtitle2(float timer)
    {
        yield return new WaitForSeconds(string3);
        text.text = st[index];
        index++;
        StartCoroutine(subtitle3(timer));
    }
    public IEnumerator subtitle3(float timer)
    {
        yield return new WaitForSeconds(string4);
        text.text = st[index];
        index++;
        StartCoroutine(subtitle4(timer));
    }
    public IEnumerator subtitle4(float timer)
    {
        yield return new WaitForSeconds(string5);
        text.text = st[index];
        index++;
        StartCoroutine(subtitle5(timer));
    }
    public IEnumerator subtitle5(float timer)
    {
        yield return new WaitForSeconds(string6);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
