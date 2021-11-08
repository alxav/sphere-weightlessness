using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SetGravity(other.gameObject, false);
    }
    private void OnTriggerExit(Collider other)
    {
        SetGravity(other.gameObject, true);
    }

    private void SetGravity(GameObject obj, bool flag)
    {
        var rb = obj.GetComponent<Rigidbody>();
        if (rb)
        {
            rb.useGravity = flag;
            rb.isKinematic = !flag;
        }
        
    }
}
