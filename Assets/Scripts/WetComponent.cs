using UnityEngine;

public class WetComponent : MonoBehaviour
{
    private const int MAX_WET = 100;
    
    [SerializeField] private Material m_bodyMaterial;
    [SerializeField] private WetBar m_wetBar;

    private bool m_isBurning;
    private bool m_isWet;

    private int m_currentWet;
    void Start()
    {
        SetColor(Color.blue);
        m_currentWet = MAX_WET;
        m_wetBar.SetMaxWet(MAX_WET);
        m_wetBar.SetWetBarValue(MAX_WET);
    }

    private void SetColor(Color _color)
    {
        m_bodyMaterial.color = _color;
    }

    public void IncreaseWet(int _value)
    {
        m_currentWet += _value;
        SetColor(Color.blue);
        m_wetBar.SetWetBarValue(m_currentWet);

        var burning = gameObject.GetComponent<Burning>();
        if (burning)
            Destroy(burning);
    }
    
    public void DecreaseWet(int _value)
    {
        m_currentWet -= _value;
        m_wetBar.SetWetBarValue(m_currentWet);
        if (m_currentWet <= 0)
        {
            SetColor(Color.red);

            var burning = gameObject.GetComponent<Burning>();

            if (burning)
                burning.ResetBurnTime();
            else
                burning = gameObject.AddComponent<Burning>();
        }
    }
}
