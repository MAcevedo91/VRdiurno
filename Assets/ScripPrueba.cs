using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripPrueba : MonoBehaviour
{
    // Variable para almacenar el Renderer del objeto
    private Renderer objectRenderer;

    void Start()
    {
        // Obtener el Renderer del objeto
        objectRenderer = GetComponent<Renderer>();

        // Cambiar el color del Albedo del material a rojo
        objectRenderer.material.SetColor("_Color", Color.red);  // O cualquier otro color que prefieras
    }

    // Update is called once per frame
    void Update(){ }
    public void OnPointerEnter()
    {
        Debug.Log("on point enter ---- ");
    }
    public void OnPointerExit()
    {
        Debug.Log("on point exit  -----");
    }
    public void OnPointerClick()
    {
        Debug.Log("on point click ---- ");
    }
}
