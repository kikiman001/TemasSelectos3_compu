using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarSkybox : MonoBehaviour
{
        private int currentIndex = 0; // �ndice del objeto actual.

    // Start is called before the first frame update
    void Start()
    {
        // Activa solo el primer objeto al inicio.
        CambiarObjeto(currentIndex);
    }

    // Update is called once per frame
    void Update()
    {
        // Detecta toques en la pantalla.
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Desactiva el objeto actual.
            DesactivarObjeto(currentIndex);

            // Avanza al siguiente objeto en la lista.
            currentIndex = (currentIndex + 1) % transform.childCount;

            // Activa el nuevo objeto.
            CambiarObjeto(currentIndex);
        }
    }

    // Funci�n para desactivar un objeto por �ndice.
    void DesactivarObjeto(int index)
    {
        Transform objeto = transform.GetChild(index);
        objeto.gameObject.SetActive(false);
    }

    // Funci�n para activar un objeto por �ndice.
    void CambiarObjeto(int index)
    {
        Transform objeto = transform.GetChild(index);
        objeto.gameObject.SetActive(true);
    }
}
