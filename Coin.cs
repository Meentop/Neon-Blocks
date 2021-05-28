using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] string destroyerTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == destroyerTag)
        {
            Score.Enemy--;
            Destroy(gameObject);
        }
    }
}
