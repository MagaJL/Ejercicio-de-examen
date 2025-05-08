using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{

    public string tipoDeEntrenamiento;
    public int cantidadDeHoras;
    int precioHoraCardio = 1000;
    int precioHoraFuerza = 1500;
    int precioHoraRecreativo = 2500;
    float precio;

    // Start is called before the first frame update
    void Start()
    {
        if (tipoDeEntrenamiento != "Cardio" && tipoDeEntrenamiento != "Fuerza" && tipoDeEntrenamiento != "Recreativo")
        {
            Debug.Log("El tipo de entrenamiento ingrsado no es válido.");
            return;
        }
        else if (cantidadDeHoras > 6 || cantidadDeHoras < 1)
        {
            Debug.Log("La cantidad de horas ingrsadas no son válidas.");
            return;
        }

        if (tipoDeEntrenamiento == "Cardio")
        {
            precio = precioHoraCardio * cantidadDeHoras;
        }
        else if (tipoDeEntrenamiento == "Fuerza")
        {
            precio = precioHoraFuerza * cantidadDeHoras;
        }
        else if (tipoDeEntrenamiento == "Recreativo")
        {
            precio = precioHoraRecreativo * cantidadDeHoras;
        }
        if (cantidadDeHoras == 6)
        {
            precio = precio - precio * 0.1f;
        } 

        Debug.Log("- Tipo de entrenamiento: " + tipoDeEntrenamiento + "\n" + "- Horas reservadas: " + cantidadDeHoras);

        Debug.Log("- Precio total: $" + precio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
