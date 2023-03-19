using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congrat : MonoBehaviour
{
    public GameObject finish;
    private void OnTriggerEnter(Collider other)
    {
        finish.SetActive(true);
        Destroy(gameObject);
    }
}
