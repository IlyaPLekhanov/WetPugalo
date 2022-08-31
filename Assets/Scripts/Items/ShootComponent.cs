using UnityEngine;

public class ShootComponent : IItemClass
{
    [SerializeField] private GameObject m_bulletPrefab;
    [SerializeField] private Transform m_shootPoint;
    [SerializeField] private float m_power;
    
    void Update()
    {
        if (m_taken && Input.GetMouseButtonDown(m_slotNumber))
        {
            var bullet = Instantiate(m_bulletPrefab, m_shootPoint.position, m_shootPoint.rotation, null);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * m_power;
        }
    }
}
