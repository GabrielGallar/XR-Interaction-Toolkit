using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ActualizarUI : MonoBehaviour
{
    private TMP_Text mensaje;
    private XRGrabInteractable interactuable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        mensaje = FindAnyObjectByType<TMP_Text>();
        interactuable = GetComponent<XRGrabInteractable>();
        interactuable.selectEntered.AddListener(CambiarUISeleccionar);
    }

     private void CambiarUISeleccionar(SelectEnterEventArgs args)
    {
        mensaje.text = "¡Has agarrado la señal!";
    }
}
