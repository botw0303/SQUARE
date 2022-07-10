using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleHPViewer : MonoBehaviour
{
    [SerializeField] CastleHP castleHP;

    Slider sliderHP;

    void Start()
    {
        sliderHP = GetComponent<Slider>();
    }

    void Update()
    {
        sliderHP.value = castleHP.CurrentHP / castleHP.MaxHP;
    }
}
