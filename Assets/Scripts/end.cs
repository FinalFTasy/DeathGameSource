using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class end : MonoBehaviour
{
    public float start;
    public float string1;
    public float string2;


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
        StartCoroutine(subtitle2(timer));
    }
    public IEnumerator subtitle2(float timer)
    {
        yield return new WaitForSeconds(string2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
