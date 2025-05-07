using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    public int cantidadDeUnidades;
    public float periodoDeDias;
    float costoDeLitroXUnidadXDia = 780;
    float costoTotalCombustible;
    float costoTotalConDescuento;
    float descuento = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        if (periodoDeDias < 5 || cantidadDeUnidades < 1)
        {
            Debug.Log("Alguno de los datos ingresados es invalido.");
            return;
        }
        else 
        {
            costoTotalCombustible = costoDeLitroXUnidadXDia * cantidadDeUnidades * periodoDeDias;

            if (costoTotalCombustible > 130000)
            {
                costoTotalCombustible = costoTotalCombustible - costoTotalCombustible * descuento;
            }
            else
            {
                costoTotalCombustible = costoTotalCombustible;
            }

            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + 
                periodoDeDias + " días implicará un gasto de $" + costoTotalCombustible + " pesos en concepto de combustible.");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
