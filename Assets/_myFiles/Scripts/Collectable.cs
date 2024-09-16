using System;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private int sectionIndex;
    private Map mapSection;
    void Start()
    {
       mapSection = GetComponent<Map>();
    }
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MapKey"))
        {
            mapSection.UnlockMapSection(sectionIndex);
            Destroy(gameObject);
        }

    }
}
