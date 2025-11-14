using System;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int currentScore = 0;
    static ScoreKeeper instance;
       void Awake()
    {
        ManageSingleton();
    }

    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } 
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }

    public void AddToCurrentScore(int scoredValue)
    {
        currentScore += scoredValue;
        Mathf.Clamp(currentScore, 0, int.MaxValue); //Make so the score never goes bellow zero
        Debug.Log(currentScore);
    }

    public void ResetCurrentScore()
    {
        currentScore = 0;
    }

}
