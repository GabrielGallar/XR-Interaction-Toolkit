using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CambiarColor : MonoBehaviour
{
    private Color colorOriginal;
    private Renderer rend;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactuable;

    void Awake ()
    {
        rend = GetComponent<Renderer>();
        colorOriginal = rend.material.color;
        interactuable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactuable.selectEntered.AddListener(CambiarColorSeleccionar);
        interactuable.selectExited.AddListener(CambiarColorDeseleccionar);
    }

    // Update is called once per frame
    private void CambiarColorSeleccionar(SelectEnterEventArgs args)
    {
        if (gameObject.name == "Cube")
        {
            rend.material.color = Color.green;
        }
        else
        {
            rend.material.color = Color.yellow;
        }
    }

    private void CambiarColorDeseleccionar(SelectExitEventArgs args)
    {
        rend.material.color = colorOriginal;
    }
}
