//9. Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    public float capitalAportado1; //monto 1
    float porcentaje1; //%
    public string nombre1; //nombre aporte 1

    public float capitalAportado2; //monto 2
    float porcentaje2; //%
    public string nombre2; //nombre aporte 

    public float capitalAportado3; //monto 3
    float porcentaje3; //%
    public string nombre3; //nombre aporte 3

    float total; //suma aportes

    // Start is called before the first frame update

    void Start()
    {
        total = capitalAportado1 + capitalAportado2 + capitalAportado3;

        porcentaje1 = (capitalAportado1 * 100) / total;

        porcentaje2 = (capitalAportado2 * 100) / total;

        porcentaje3 = (capitalAportado3 * 100) / total;

        Debug.Log("Nombre: " + nombre1 + ", capital aportado: $" + capitalAportado1 + ", porcentje del capital: %" + porcentaje1 + ", Monto total aportado: $" + total); //Usuario1

        Debug.Log("Nombre: " + nombre2 + ", capital aportado: $" + capitalAportado2 + ", porcentje del capital: %" + porcentaje2 + ", Monto total aportado: $" + total); //Usuario2

        Debug.Log("Nombre: " + nombre3 + ", capital aportado: $" + capitalAportado3 + ", porcentje del capital: %" + porcentaje3 + ", Monto total aportado: $" + total); //Usuario3
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
