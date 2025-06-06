using UnityEngine;

public class CameraController : MonoBehaviour
{
 public float scrollSpeed = 0.3f;

    void Update() {
        transform.position += Vector3.down * scrollSpeed * Time.deltaTime;
    }
}
