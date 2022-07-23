using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawnner : MonoBehaviour
{
    Vector3 lastpos;
    float size;
    public GameObject Platform;


    // Start is called before the first frame update
    void Start()
    {
        lastpos = Platform.transform.position;
        size = Platform.transform.localScale.x;

        for (int i = 0; i < 5; i++)
        {
            SpawnZ();
        }
    }

    // Update is called once per frame
    void Update()
    {
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
