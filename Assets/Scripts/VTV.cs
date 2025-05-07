using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{
    public int patente;
    public int modelo;
    public int kilometrosRecorridos;
    public int vencimientoVTV;
    public int HC;

    // Start is called before the first frame update
    void Start()
    {
        if (patente == 0 || modelo < 1900 || modelo > 2025 || kilometrosRecorridos < 0 || vencimientoVTV > 2025 || vencimientoVTV < modelo || HC < 5 || HC > 100)
        {
            Debug.Log("Alguno de los datos no es válido. " +
                "VTV no aprobada.");
            return;
        }
        else if (kilometrosRecorridos < 10000)
        {
            Debug.Log("VTV otorgada por 2 años.");
        }
        else
        {
            Debug.Log("VTV otorgada por 1 año.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
