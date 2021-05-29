using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] Phases phases;

    public float speed = 2f;

    private void Start()
    {
        Score.Enemy = 0;
        Score.phases = 0;
        Score.coins = 0;
        Score.playerAlive = true;
    }

    private void Update()
    {
        if(Score.Enemy == 0)
        {
            if (Score.playerAlive)
            {
                int randPhase = Random.Range(0, 4);
                if (randPhase != 3)
                {
                    if (Score.phases <= 6)
                    {
                        StartBlockPhase(2, 2, ref Score.phases);
                    }
                    else if (Score.phases > 6 && Score.phases <= 12)
                    {
                        speed += 0.03f;
                        StartBlockPhase(2, 3, ref Score.phases);
                    }
                    else if (Score.phases > 12)
                    {
                        speed += 0.03f;
                        StartBlockPhase(3, 4, ref Score.phases);
                    }
                }
                else if (randPhase == 3)
                {
                    StartCoinsPhase(2, 2, ref Score.phases);
                }
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

}