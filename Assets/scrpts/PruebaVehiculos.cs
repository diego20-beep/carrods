using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaVehiculos : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        Carro_carro = new carro
        {
            (nombre = "cocheDeportivo",velocidad=200,capacidadCombustible=50,combustibleActual = 20,numeroPuertas = 2);
        carro.Acelerar();
        carro.Frenar();
        carro.Tanquear();
    }
}
}