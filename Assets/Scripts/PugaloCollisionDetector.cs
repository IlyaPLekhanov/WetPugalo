using UnityEngine;

public class PugaloCollisionDetector : MonoBehaviour
{
    [SerializeField] private WetComponent m_wetComponent;
    [SerializeField] private Health m_health;

    private void OnCollisionEnter(Collision collision)
    {
        var damageContainer = collision.gameObject.GetComponent<DamageContainer>();
        if (damageContainer)
                m_health.ReduceHealth(damageContainer.damage);
        
        var wetContainer = collision.gameObject.GetComponent<WetContainer>();
        if (wetContainer)
            m_wetComponent.IncreaseWet(wetContainer.wetValue);
    }

    void OnParticleCollision(GameObject other)
    {
        var fireContainer = other.GetComponent<FireContrainer>();
        if (fireContainer)
            m_wetComponent.DecreaseWet(fireContainer.fireValue);
        
        var damageContainer = other.GetComponent<DamageContainer>();
        if (damageContainer)
            m_health.ReduceHealth(damageContainer.damage);
    }
}
