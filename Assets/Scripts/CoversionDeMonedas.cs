using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoversionDeMonedas : MonoBehaviour
{
    //1. declaracion de variables
    public float monto; // float cuando el numero puede ser con coma
    public string codigoMoneda; // string son caracteres

    float montoConvertido;
    float montoMinimoAConvertir = 1000;

    float cotizacionMonedaElegida;
    float cotizacionEuro = 1621.3f;
    float cotizacionDolar = 1293.21f;
    float cotizacionReal = 1336.7f;
    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso y validacion de datos
        
        if( monto < montoMinimoAConvertir)
        {
            Debug.Log(" El monto minimo es $1000 ");
            return;
        }
        if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
        }else if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = cotizacionDolar;
        }
        else if (codigoMoneda == "R")
        {
            cotizacionMonedaElegida = cotizacionReal;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }

            //3. Procesamiento de datos

            montoConvertido = monto / cotizacionMonedaElegida;

        //4. Salida de datos
        Debug.Log("La cotizacion de ese monto de pesos es" + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
