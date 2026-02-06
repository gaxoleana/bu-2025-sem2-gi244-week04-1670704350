using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    void Update()
    {
        if (transform.position.z > 20)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
