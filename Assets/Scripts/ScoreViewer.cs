using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreViewer : MonoBehaviour
{
    #region ½Ì±ÛÅæ
    public static ScoreViewer Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    #endregion

    [SerializeField]
    TextMeshProUGUI textScore;
    [SerializeField]
    TextMeshProUGUI bestScoreText;

    private float _currentScore;
    public float CurrentScore => _currentScore;

    private float _bestScore;

    private void Start()
    {
        _bestScore = PlayerPrefs.GetFloat("BestScore", 0);
    }

    private void Update()
    {
        textScore.text = $"Score : {_currentScore}";
        bestScoreText.text = $"BestScore : {_bestScore}";
    }

    public void ScoreUP()
    {
        _currentScore += 10f;
        if(_currentScore >= _bestScore)
        {
            _bestScore = _currentScore;
            PlayerPrefs.SetFloat("BestScore", _bestScore);
        }
    }


}
