using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] Phases phases;

    public float enemySpeed = 2f;

    private void Update()
    {
        if(Score.Enemy == 0)
        {
            if (GameObject.FindGameObjectsWithTag("Player").Length == 1)
            {
                if (Score.phases <= 6)
                {
                    StartBlockPhase(2, 2, ref Score.phases);
                }
                else if (Score.phases > 6 && Score.phases <= 12)
                {
                    enemySpeed += 0.03f;
                    StartBlockPhase(2, 3, ref Score.phases);
                }
                else if (Score.phases > 12)
                {
                    enemySpeed += 0.03f;
                    StartBlockPhase(3, 4, ref Score.phases);
                }
            }
        }
    }

    private void StartBlockPhase(int min, int max, ref int scorePhases)
    {
        phases.BlockPhase(Random.Range(min, max + 1), ref Score.Enemy);
        scorePhases++;
    }
}