using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
    public Transform target;
    float timeElapsed = 0f, duration = 10000f;
    void Update()
    {
        Vector3 startPos = transform.position;

        transform.position = Vector3.Lerp(startPos, target.transform.position, timeElapsed / duration);
        timeElapsed += Time.deltaTime;


    }
}
