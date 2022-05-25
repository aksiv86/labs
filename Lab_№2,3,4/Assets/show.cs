using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show : MonoBehaviour
{
    public GameObject Buy;
    void Start()
    {
        Buy.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Buy.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        Buy.SetActive(false);
    }
}
