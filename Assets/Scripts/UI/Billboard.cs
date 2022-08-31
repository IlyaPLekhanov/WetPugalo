using UnityEngine;

public class Billboard : MonoBehaviour
{
    [SerializeField] private Transform m_player;
    
    void LateUpdate()
    {
        transform.LookAt(m_player);
    }
}
