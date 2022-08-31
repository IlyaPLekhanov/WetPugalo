using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IItemClass : MonoBehaviour
{
    public bool m_taken { get; private set; }
    public int m_slotNumber { get; private set; }

    public void SetToSlot(int _slot)
    {
        m_slotNumber = _slot;
        m_taken = true;
    }

    public void DropItem()
    {
        m_taken = false;
    }
}
