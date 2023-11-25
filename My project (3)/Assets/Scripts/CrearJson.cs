using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;
using TMPro;

public class CrearJson : MonoBehaviour
{
    public GameObject imagen;
    public void crearInformacion()
    {
        List<Informacion> info = new List<Informacion>();
        Debug.Log(imagen.transform.childCount);
        // Recorrer todos los hijos del objeto
        float[] posX = new float[imagen.transform.childCount];
        float[] posY = new float[imagen.transform.childCount];
        string[] nombres = new string[imagen.transform.childCount];
        for (int i = 0; i < imagen.transform.childCount; i++)
        {
            // Acceder a cada hijo individual
            Transform hijo = imagen.transform.GetChild(i);
            posX[i] = hijo.localPosition.x;
            Debug.Log(hijo.localPosition.x);
            posY[i] = hijo.localPosition.y;
            hijo = hijo.GetChild(0).Find("Text");
            Debug.Log(hijo.GetComponent<TextMeshProUGUI>());
            nombres[i] = hijo.GetComponent<TextMeshProUGUI>().text;
            Debug.Log(nombres);
        }
        InformacionTextos jsonObject = new InformacionTextos(nombres, posX, posY);
        string json = JsonConvert.SerializeObject(jsonObject);
        File.WriteAllText("punto.txt", json);
    }
}
