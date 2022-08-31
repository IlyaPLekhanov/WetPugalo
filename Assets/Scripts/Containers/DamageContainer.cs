using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageContainer : MonoBehaviour
{
    [SerializeField] private int m_damage;
    public int damage => m_damage;
}
