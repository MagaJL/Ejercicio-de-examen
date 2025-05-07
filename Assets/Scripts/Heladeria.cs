using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string codigoGustos;
    public float gramos;
    float precio;
    float promo = 0.1f;
    float precioTotal;

    // Start is called before the first frame update
    void Start()
    {
        if (codigoGustos != "CHO" && codigoGustos != "DDL" && codigoGustos != "FRU")
        {
            Debug.Log("Código ingresado no valido.");
            return;
        }
        else if (gramos < 250 || gramos >3000)
        {
            Debug.Log("Cantidad de helado ingresada no valida.");
            return;
        }

        if (codigoGustos == "FRU")
        {
            precio = gramos * 500 / 1000;
            precioTotal = precio - precio * promo;
        }
        else
        {
            precio = gramos * 500 / 1000;
            precioTotal = precio;
        }
        Debug.Log("El costo de su pedido es: $" + precioTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
