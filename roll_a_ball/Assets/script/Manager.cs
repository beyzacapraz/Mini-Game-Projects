using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class manager : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine("BallTouch");

        
    }

    IEnumerator BallTouch()
    {

        yield return new WaitForSeconds(4f);
        Debug.Log("Your time is up");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void StartTimer()
    {
        StopCoroutine("BallTouch");
        StartCoroutine("BallTouch");
    }

}
