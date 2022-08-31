using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image m_healthBar;
    private int m_maxHealth;

    public void SetHealthBarValue(int m_currentHealth)
    {
        m_healthBar.fillAmount = 1f * m_currentHealth / m_maxHealth;
    }

    public void SetMaxHealth(int m_health)
    {
        m_maxHealth = m_health;
    }
}
