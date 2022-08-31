using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : IItemClass
{
    [SerializeField] private ParticleSystem m_particleSystem;
    
    ParticleSystem.EmissionModule m_em;

    private void Start()
    {
        m_em = m_particleSystem.emission;
    }

    void Update()
    {
        if (m_taken && Input.GetMouseButton(m_slotNumber))
            m_em.rate = 5;
        else
            m_em.rate = 0;
    }
}
