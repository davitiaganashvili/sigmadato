using UnityEngine;

public class teleport : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log(other.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }

}


