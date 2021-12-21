using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
    static public int health;
    public Image[] hearts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hearts.Length; ++i)
        {
            if (i < health)
                hearts[i].enabled = true;
            else hearts[i].enabled = false;
        }
    }

    public void DecreaseHealth()
    {
        if (health > 0)
            --health;
    }
}
