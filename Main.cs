using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] Phases phases;

    private void Update()
    {
        if(Score.Enemy == 0)
        {
            phases.BlockPhase(Random.Range(2, 5), ref Score.Enemy);
        }
    }
}