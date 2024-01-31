using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_script : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] float speed;
    int reward = 0;
    public manager manager;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Start()
    {

    }


    void Update()
    {
        float x_axis = Input.GetAxisRaw("Horizontal");
        float z_axis = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(x_axis, 0, z_axis);

        rb.AddForce(vec * speed);

    }
    void OnTriggerEnter(Collider other)
    {
        
        
        if (other.gameObject.tag.Equals("coin"))
        {

            manager.StartTimer();
            reward++;
            Debug.Log("collected coins : " + reward);
        }
        else if (other.gameObject.tag.Equals("bomb"))
        {

            reward--;
            if (reward < 0)
            {
                gameObject.SetActive(false);
                Debug.Log("Game Over!!!!" + "\n collected coins : " + reward);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


            }
            else Debug.Log("You exploded!!" + "\n collected coins : " + reward);
        }

        

        

    }

    void OnCollisionEnter(Collision collision)
    {

        
        if (collision.gameObject.tag.Equals("obstacle") && reward <= 0)
        {

            gameObject.SetActive(false);
            reward--;
            Debug.Log("collected coins : " + reward);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (collision.gameObject.tag.Equals("door")){
            reward = 0;
            Debug.Log("collected coins: "  + reward);
        }

        else if (collision.gameObject.tag.Equals("obstacle"))
        {

            reward--;
            Debug.Log("You hit the wall!!" + "\n collected coins : " + reward);
            

        }
        else if (collision.gameObject.tag.Equals("end"))
        {
            
            gameObject.SetActive(false);
            Debug.Log("You Won!!!!" + "\n collected coins : " + reward);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }
}

