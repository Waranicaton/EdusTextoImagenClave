using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Informacion
{
    public string nombre { set; get; }
    public float posX { set; get; }
    public float posY { set; get; }

    public Informacion()
    {
        nombre = "";
        posX = 0;
        posY = 0;
    }

    public Informacion(string nombre, float posX, float posY)
    {

        this.nombre = nombre;
        this.posX = posX;
        this.posY = posY;

    }
}
