using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_textScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.instance.OnObstacleDestroyedAction += UpdateScoreText;
        UpdateScoreText(0);
    }

    private void UpdateScoreText(int _iScore)
    {
        m_textScore.text = $"Player score {_iScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
