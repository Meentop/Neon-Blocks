using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsMover : Mover
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
