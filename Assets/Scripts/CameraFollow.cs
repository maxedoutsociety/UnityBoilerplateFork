using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2(target.position.x, transform.position.y), 10 * Time.deltaTime);  
    }
}
