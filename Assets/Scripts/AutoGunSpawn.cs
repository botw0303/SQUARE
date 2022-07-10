using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGunSpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> AGTL = new List<GameObject>();
    

    void Start()
    {
        
    }

    void Update()
    {
        if(ScoreViewer.Instance.CurrentScore >= 100)
        {
            AGTL[0].SetActive(true);
        }
        if(ScoreViewer.Instance.CurrentScore >= 200)
        {
            AGTL[1].SetActive(true);
        }
        if (ScoreViewer.Instance.CurrentScore >= 300)
        {
            AGTL[2].SetActive(true);
        }
        if (ScoreViewer.Instance.CurrentScore >= 400)
        {
            AGTL[3].SetActive(true);
        }
    }
}
