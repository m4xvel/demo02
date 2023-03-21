using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 target; 

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            other.transform.position = target;
        }
    }
}
