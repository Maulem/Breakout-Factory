using UnityEngine;

public class CircularPath : MonoBehaviour
{
    public Transform center;
    public float speed = 1f;
    public float radius = 1f;

    private float angle;

    void Update()
    {
        angle += speed * Time.deltaTime;
        transform.position = center.position + new Vector3(Mathf.Cos(angle) * radius, Mathf.Sin(angle) * radius, 0);
    }
}

