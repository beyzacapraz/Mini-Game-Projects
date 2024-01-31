using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int balancer = 1;
    private void Update()
    {
        transform.Rotate(new Vector3(0, 30, 0) * ((Time.deltaTime)/balancer)*5);
    }
}
