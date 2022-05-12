using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public GameObject cube;
    
    public Camera _camera;
    
    private Vector3 screenV;

    private float radian;//弧度

    private float dx;

    private float dz;

    private float angle;

    private Text V_text;

    public string s;

    public static int count = 10;

    public static int flag = 1;

    private Rigidbody rb;

    private float v = 0f;
    
    public static bool ChangeCamera = false;
    
    public AudioSource source;



    private float timer = 2f;
    
    // Start is called before the first frame update
    void Awake()
    {
        //_camera = Camera.current;
        rb = GetComponent<Rigidbody>();
        screenV = _camera.WorldToScreenPoint(transform.position);
        source = GetComponent<AudioSource>();
        source.Pause();
    }

    // Update is called once per frame
    void Update()
    {

        if (ChangeCamera)
        {
            EffortChange();
            if (Input.GetMouseButton(0))
            {
                ShowLine();
            }
            else
            {
                GetComponent<LineRenderer>().SetPosition(0, transform.position);
                GetComponent<LineRenderer>().SetPosition(1, transform.position);
            }

            if (Input.GetMouseButtonDown(0))
            {
                v = 0f;
            }

            if (Input.GetMouseButtonUp(0))
            {
                AudioPlay();
                Vector3 dianV = Input.mousePosition;
                dianV.z = screenV.z;
                Vector3 wv = _camera.ScreenToWorldPoint(dianV);
                Vector3 cubePosition = transform.position;

                float ddx = wv.x - cubePosition.x;
                float ddz = wv.z - cubePosition.z;

                radian = Mathf.Atan2(ddz, ddx);

                dx = v * Mathf.Cos(radian);
                dz = v * Mathf.Sin(radian);
            
                rb.velocity = new Vector3(dx,0f,dz);
            }
        }
        
    }

    public void AudioPlay()
    {
        timer += Time.frameCount;
        source.Play();
    }
    
    public void EffortChange()
    {
        if (System.Math.Abs(rb.velocity.x) >= 0.001f || System.Math.Abs(rb.velocity.z) >= 0.001f)
        {
            rb.drag = (float) (System.Math.Sqrt(rb.drag + Time.deltaTime) / 1.2);
        }
        else
        {
            rb.drag = 0;
        }
    }

    public void ShowLine()
    {
        v += Time.deltaTime * 30f;
        /*if (rb.drag != 0)
        {
            V_text.text = "V=" + ((int) (v / 5)).ToString();
        }*/
        /*else
        {
            
        }*/

        Vector3 dianV_line = Input.mousePosition;//我鼠标位置是不是有问题啊？——已解决
        dianV_line.z = screenV.z;
        Vector3 wv_line = _camera.ScreenToWorldPoint(dianV_line);
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        GetComponent<LineRenderer>().SetPosition(1, wv_line);
    }
}
