using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Mover
{
    [SerializeField] string destroyerTag;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == destroyerTag)
        {
            Score.Enemy--;
            Destroy(gameObject);
        }
    }
}
