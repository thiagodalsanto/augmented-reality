using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 0.1f * Time.deltaTime);
    }
}
