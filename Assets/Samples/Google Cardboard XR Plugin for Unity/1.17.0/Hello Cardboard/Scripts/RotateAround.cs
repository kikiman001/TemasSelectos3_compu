using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform centroDelCarrusel;
    public float velocidadRotacion = 30f;
    public float retrasoInicial = 0f; // El primer hijo no tiene retraso.

    private float[] tiemposDeRetraso; // Almacena los tiempos de retraso para cada hijo.

    void Start()
    {
        // Inicializa los tiempos de retraso para cada hijo.
        tiemposDeRetraso = new float[transform.childCount];
        for (int i = 0; i < tiemposDeRetraso.Length; i++)
        {
            tiemposDeRetraso[i] = retrasoInicial + i * 1.8f; // Aumenta el retraso para cada hijo.
        }
    }

    void Update()
    {
        // Rotar todas las imágenes alrededor del centro con su retraso respectivo.
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform imagen = transform.GetChild(i);
            float tiempoDeRetraso = tiemposDeRetraso[i];

            if (Time.time >= tiempoDeRetraso)
            {
                imagen.RotateAround(centroDelCarrusel.position, Vector3.up, velocidadRotacion * Time.deltaTime);
            }
        }
    }
}