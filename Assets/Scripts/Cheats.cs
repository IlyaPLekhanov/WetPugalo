using UnityEngine;

public class Cheats : MonoBehaviour
{
    [SerializeField] private Health m_healh;
    [SerializeField] private WetComponent m_wet;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            m_healh.Resurrect();
            m_wet.IncreaseWet(100);
        }
    }
}
