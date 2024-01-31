using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class health_manager : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] float damage = 20f;
    player_stats stats;
    private void Awake()
    {
        stats = GetComponent<player_stats>();

        
    }
    private void Apply_Damage()
    {
        if (health <= 0)
        {
            Debug.Log("You died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        health -= damage;
        stats.DisplayHealth(health);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("cannibal"))
        {
            Debug.Log("Cannibal");
            Apply_Damage();
        }
    }
}
