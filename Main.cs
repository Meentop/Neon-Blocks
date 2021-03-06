using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] Phases phases;

    [SerializeField] GameObject pausePanel, pauseButton;

    public float speed = 2f;

    private void Start()
    {
        Score.Enemy = 0;
        Score.phases = 0;
        Score.coins = 0;
        Score.playerAlive = true;
        PauseOff();
    }

    private void Update()
    {
        if(Score.Enemy == 0 && Score.playerAlive)
        {
            int randPhase = Random.Range(0, 4);
            if (randPhase != 3)
            {
                if (Score.phases <= 6)
                {
                    speed += 0.02f;
                    StartBlockPhase(2, 2, ref Score.phases);
                }
                else if (Score.phases > 6 && Score.phases <= 12)
                {
                    speed += 0.02f;
                    StartBlockPhase(2, 3, ref Score.phases);
                }
                else if (Score.phases > 12)
                {
                    speed += 0.02f;
                    StartBlockPhase(3, 4, ref Score.phases);
                }
            }
            else if (randPhase == 3)
            {
                speed += 0.02f;
                StartCoinsPhase(2, 2, ref Score.phases);
            }
        }
    }

    private void StartBlockPhase(int min, int max, ref int scorePhases)
    {
        phases.BlockPhase(Random.Range(min, max + 1), ref Score.Enemy);
        scorePhases++;
    }

    private void StartCoinsPhase(int min, int max, ref int scorePhases)
    {
        phases.CoinsPhase(Random.Range(min, max + 1), ref Score.Enemy);
        scorePhases++;
    }

    public void PauseOn()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void PauseOff()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
    }
}