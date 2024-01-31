
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_stats : MonoBehaviour
{
    [SerializeField] Image health_bar;
    // Start is called before the first frame update
    public void DisplayHealth(float health_value)
    {
        health_value /= 100f;
        health_bar.fillAmount = health_value;
        
    }
}
