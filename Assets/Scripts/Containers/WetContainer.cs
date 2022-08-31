using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetContainer : MonoBehaviour
{
    [SerializeField] private int m_wetValue;
    public int wetValue => m_wetValue;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
