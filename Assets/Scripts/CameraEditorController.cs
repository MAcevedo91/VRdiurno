using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 2.0f; // Sensibilidad ajustada para un movimiento más suave
    public float maxVerticalAngle = 80f; // Limita la rotación vertical para evitar que se voltee la cámara
    private float rotationX = 0f;
    private float rotationY = 0f;

    void Update()
    {
#if UNITY_EDITOR
        // Verifica si el click principal (botón izquierdo) está presionado
        if (Input.GetMouseButton(0))
        {
            // Captura el movimiento del mouse
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            // Ajustamos la rotación horizontal (en el eje Y) y vertical (en el eje X)
            rotationX -= mouseY; // invertimos el mouseY para que se mueva de manera más natural
            rotationY += mouseX;

            // Limitar la rotación vertical (en el eje X) para evitar que el jugador mire completamente hacia arriba o hacia abajo
            rotationX = Mathf.Clamp(rotationX, -maxVerticalAngle, maxVerticalAngle);

            // Aplicar las rotaciones
            transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
        }
#endif
    }
}
