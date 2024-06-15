using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class vehiculo : MonoBehaviour;
{
    // Start is called before the first frame update
    public string nombre;
    public float velocidad;
    public int capacidadCombustible;
    public int combustibleActual;

    public virtual void Acelerar()
    {
        Debug.Log(nombre + "esta acelerando a" + "Km/h");
    }
    public void Frenar()
    {
        Debug.Log(nombre + "esta frenando");
    }
    public void Tanquear(int cantidad);
    {
        combustibleActual += cantidad;
    }
if (combustibleActual > capacidadCombustible)
{
    (combustibleActual = capacidadCombustible);
}
{
    Debug.Log(nombre, "ha quedado.combustibleActual" + combustibleActual);
}
}