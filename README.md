# XR-Interaction-Toolkit
Esta es la práctica 5 de la asignatura de "Interfaces Inteligentes"

<img width="1280" height="720" alt="Interactuable" src="https://github.com/user-attachments/assets/d6890af1-e610-4f26-9e16-f0c2ebd38609" />

# Hitos CambiarColor
- Configuramos nuestro objeto de renderizado y color al igual que el XRGrabInteractable (para que sea agarrable).
- Ponemos a la escucha a nuestro objeto XR para cuando haya sido seleccionado y deseleccionado, reaccionando con la función CambiarColorSeleccionar(SelectEnterEventArgs args) y CambiarColorDeseleccionar(SelectEnterEventArgs args) respectivamente.
- Con CambiarColorSeleccionar(SelectEnterEventArgs args) cambiamos el color de nuestro gameObject tanto si es la esfera o el cubo a través de su renderizado.
- Con CambiarColorDeseleccionar(SelectEnterEventArgs args) restauramos el color de nuestro gameObject a través del objeto color.

# Hitos ActualizarUI
- Configuramos nuestro objeto TMPro al igual que el XRGrabInteractable (para que sea agarrable).
- Ponemos a la escucha a nuestro objeto XR para cuando haya sido seleccionado, reaccionando con la función CambiarUISeleccionar(SelectEnterEventArgs args).
- Con CambiarUISeleccionar(SelectEnterEventArgs args) accedemos y cambiamos el mensaje de nuestro objeto TMPro (TMP_Text) a "¡Has agarrado la señal!".
