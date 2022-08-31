using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int m_maxHealth;
    [SerializeField] private HealthBar m_healthBar;

    private int m_currentHealth;
    
    void Start()
    {
        m_currentHealth = m_maxHealth;
        m_healthBar.SetMaxHealth(m_maxHealth);
    }

    public void ReduceHealth(int _health)
    {
        m_currentHealth -= _health;
        m_healthBar.SetHealthBarValue(m_currentHealth);

        if (m_currentHealth <= 0)
            Dying();
    }

    private void Dying()
    {
        gameObject.SetActive(false);
    }

    public void Resurrect()
    {
        gameObject.SetActive(true);
        m_currentHealth = m_maxHealth;
    }
}
