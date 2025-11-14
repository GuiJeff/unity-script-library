using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;
    void Awake()
    {
        scoreKeeper = FindAnyObjectByType<ScoreKeeper>();

    }

    public void ShowFinalScore()
    {
        finalScoreText.text = $"QUIZ FINALIZADO!\nSUA PONTUAÇÃO FOI: {scoreKeeper.CalculateScore()}%";
    }
}
