using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus_Controller : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}
