using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFall : MonoBehaviour
{
    public GameObject ball;
    Vector3 offset;
    public float lerprate;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        offset = ball.transform.position - transform.position;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            Follow();
        }
    }

    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetpos = ball.transform.position - offset;
        pos = Vector3.Lerp(pos, targetpos, lerprate * Time.deltaTime);
        transform.position = pos;
    }
}
