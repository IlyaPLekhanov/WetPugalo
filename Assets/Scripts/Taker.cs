using UnityEngine;

public class Taker : MonoBehaviour
{
    private const float RAY_DISTANCE = 5;

    [SerializeField] private Transform m_leftHand;
    [SerializeField] private Transform m_rightHand;
    [SerializeField] private Transform m_lookPoint;

    private IItemClass m_leftHandItem;
    private IItemClass m_rightHandItem;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RaycastHit hit;
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.transform.forward);
            Physics.Raycast(ray, out hit, RAY_DISTANCE);
            
            if (m_leftHandItem)
            {
                m_leftHandItem.DropItem();
                m_leftHand.GetChild(0).parent = null;
                m_leftHandItem = null;
                return;
            }
            
            var newLeftItem = hit.transform.gameObject.GetComponent<IItemClass>();
            
            if (newLeftItem)
            {
                hit.transform.gameObject.GetComponent<IItemClass>().SetToSlot(0);
                hit.transform.gameObject.transform.position = new Vector3(m_leftHand.position.x, m_leftHand.transform.position.y, m_leftHand.transform.position.z);
                hit.transform.gameObject.transform.LookAt(m_lookPoint);
                hit.transform.parent = m_leftHand;

                m_leftHandItem = newLeftItem;
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.transform.forward);
            Physics.Raycast(ray, out hit);

            if (m_rightHandItem)
            {
                m_rightHandItem.DropItem();
                m_rightHand.GetChild(0).parent = null;
                m_rightHandItem = null;
                return;
            }
            
            var newRightItem = hit.transform.gameObject.GetComponent<IItemClass>();
            
            if (newRightItem)
            {
                hit.transform.gameObject.GetComponent<IItemClass>().SetToSlot(1);
                hit.transform.gameObject.transform.position = new Vector3(m_rightHand.position.x, m_rightHand.transform.position.y, m_rightHand.transform.position.z);
                hit.transform.gameObject.transform.LookAt(m_lookPoint);
                hit.transform.parent = m_rightHand;

                m_rightHandItem = newRightItem;
            }
        }
    }
}
