/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{

    [SerializeField] List<GameObject> lineList = new List<GameObject>();
    [SerializeField] GameObject linePrefabs;
    int lineNum = 2;
    Vector3 linePosX;


    float timer = 0;

    void Start()
    {

        linePosX = lineList[2].transform.position;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(lineNum >= 3 || lineNum >= 4)
        {
            Invoke("LineSpawn", 1);
        }

        

        //Debug.Log(timer);
    }

    void LineSpawn()
    {
        linePosX.x += 10;
        Instantiate(linePrefabs, linePosX, Quaternion.identity);
    }
}*/
