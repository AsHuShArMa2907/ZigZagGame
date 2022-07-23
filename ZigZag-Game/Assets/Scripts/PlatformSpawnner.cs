using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawnner : MonoBehaviour
{
    Vector3 lastpos;
    float size;
    public GameObject Platform;
    public bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        lastpos = Platform.transform.position;
        size = Platform.transform.localScale.x;

        for (int i = 0; i < 20; i++)
        {
            SpawnPlatform();
        }
        InvokeRepeating("SpawnPlatform", 3f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            CancelInvoke("SpawnPlatform");
        }
    }

    void SpawnPlatform()
    {
        
        int rand = Random.Range(0,6);
        if (rand < 3)
        {
            SpawnX();
        }
        else if (rand >= 3)
        {
            SpawnZ();
        }
    }

    void SpawnX()
    {
        Vector3 pos = lastpos;
        pos.x += size;
        lastpos = pos;
        Instantiate(Platform,pos, Quaternion.identity);
    }
    void SpawnZ()
    {
        Vector3 pos = lastpos;
        pos.z += size;
        lastpos = pos;
        Instantiate(Platform, pos, Quaternion.identity);

    }
}
