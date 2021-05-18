using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    [SerializeField] Transform[] spawner;
    [SerializeField] GameObject enemy;

    public void BlockPhaseSpawnEnemy()
    {
        int rand = Random.Range(0, 3);
        Instantiate(enemy, spawner[rand].position, enemy.transform.rotation);
    }
}
