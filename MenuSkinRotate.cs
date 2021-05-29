using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSkinRotate : MonoBehaviour
{
    float speed = 10f;

    [SerializeField] Transform target;

    void Start()
    {
        StartCoroutine(RandomRotate());
    }

    IEnumerator RandomRotate()
    {
        while (true)
        {
            target.transform.Rotate(new Vector3(Random.Range(-360, 360), Random.Range(-360, 360), Random.Range(-360, 360)));
            yield return new WaitForSeconds(4);
        }
    }

    private void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, Time.deltaTime * (speed - 8.5f));
    }
}
