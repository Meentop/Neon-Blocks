using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phases : MonoBehaviour
{
    [SerializeField] Spawners[] spawners;

    public void BlockPhase(int sides, ref int score)
    {
        score += sides;
        List<int> numbers = new List<int> { 0, 1, 2, 3 };
        for (int i = sides; i > 0; i--)
        {
            int rand = Random.Range(0, numbers.Count);
            spawners[numbers[rand]].BlockPhaseSpawnEnemy();
            numbers.RemoveAt(rand);
        }
    }
}
