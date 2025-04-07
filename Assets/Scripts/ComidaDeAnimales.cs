using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimales : MonoBehaviour
{
    public string codigoAnimal;
    public int diasAnimal;
    public int cantidadAlimento;

    // Start is called before the first frame update
    void Start()
    {
        if (codigoAnimal == "PP")
        {
            cantidadAlimento = 400;
        } else if (codigoAnimal == "PG")
        {
            cantidadAlimento = 700;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
