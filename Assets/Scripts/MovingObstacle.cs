using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    public Vector3 direction = Vector3.right;
    public float distance = 5f;
    public float speed = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed + distance / 2f, distance) - distance / 2f;
        transform.position = startPosition + direction.normalized * offset;
    }
}
