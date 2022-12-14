using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WetBar : MonoBehaviour
{
    [SerializeField] private Image m_wetBar;
    [SerializeField] private TMP_Text m_text;
    private int m_maxWet;

    public void SetWetBarValue(int m_currentWet)
    {
        m_wetBar.fillAmount = 1f * m_currentWet / m_maxWet;
        m_text.text = m_currentWet + " / " + m_maxWet;
    }

    public void SetMaxWet(int m_health)
    {
        m_maxWet = m_health;
    }
}
