using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilaVirtual : MonoBehaviour
{

    public string codigoDeEntrada;
    public int cantidadDeEntradas;
    public string deseaTenerPrioridad;

    // Start is called before the first frame update
    void Start()
    {
        if (codigoDeEntrada != "b" && codigoDeEntrada != "n" && codigoDeEntrada != "p" || cantidadDeEntradas < 1)
        {
            Debug.Log("Alguno de los datos ingresados es invalido.");
            return;
        }
        else if (codigoDeEntrada == "b" && cantidadDeEntradas > 4 )
        {
            Debug.Log("Cantidad de entradas ingresadas es invalido.");
            return;
        }
        else if (codigoDeEntrada == "n" && cantidadDeEntradas > 6 )
        {
            Debug.Log("Cantidad de entradas ingresadas es invalido.");
            return;
        }
        else if (codigoDeEntrada == "p")
        {
            
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
