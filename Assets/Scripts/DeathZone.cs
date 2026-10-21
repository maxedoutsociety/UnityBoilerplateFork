using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform RespawnPoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            var controller = FindAnyObjectByType<LevelUIController>();
            controller.kill();
            other.transform.position = RespawnPoint.position;     
        }
    }
}
