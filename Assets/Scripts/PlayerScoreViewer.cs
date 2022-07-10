using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScoreViewer : MonoBehaviour
{
    [SerializeField] Test test;
    TextMeshProUGUI textScore;


    void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {

    }
}
