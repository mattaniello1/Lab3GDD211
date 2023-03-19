using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Platforms : MonoBehaviour
{
    [SerializeField] protected int platformHealth;

    public virtual void platformBreak()
    {
        Destroy(gameObject);
    }
}
