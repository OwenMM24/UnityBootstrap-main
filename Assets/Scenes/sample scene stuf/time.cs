using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class time : MonoBehaviour
{
    public float speed;
    public int frameRate;
    public TMP_Text timerText;
    float times;

    private void Start()
    {
        Application.targetFrameRate = frameRate;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("-----------");

        times = Time.time;
        timerText.text = times.ToString();
        transform.position = new Vector3(transform.position.x + Time.deltaTime * speed, transform.position.y, 0);
    }
}
