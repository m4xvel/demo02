using System.Collections.Generic;
using UnityEngine;

public class TheWallofDeath : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player>().Kill();
        }
    }
}
