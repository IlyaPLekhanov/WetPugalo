using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burning : MonoBehaviour
{
    private const int MAX_BURN_TIME = 5;
    private const int DAMAGE_PER_SECOND = 5;

    public float mainTimer;
    public float timer;
    private Health m_health;

    private void Start()
    {
        m_health = GetComponent<Health>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer >= 1)
        {
            if (!m_health)
            {
                Debug.Log("No Health component on gameObject");
                return;
            }
            
            m_health.ReduceHealth(DAMAGE_PER_SECOND);
            timer = 0;
            
            mainTimer += 1;
            
            if (mainTimer >= MAX_BURN_TIME)
                Destroy(this);
        }
    }

    public void ResetBurnTime()
    {
        mainTimer = 0;
    }
}
