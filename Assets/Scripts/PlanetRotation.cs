using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotationSpeed = 10.0f; // Velocidad de rotación

    void Update()
    {
        // Rotar la Tierra alrededor del eje Y (simulando su rotación diaria)
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}