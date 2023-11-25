using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearTexto : MonoBehaviour
{
    public GameObject parentObject; // El objeto al cual quieres añadir el nuevo prefab
    public GameObject prefabToCreate; // El prefab que deseas instanciar

    public void InstantiatePrefabAsChild()
    {
        GameObject newObject = Instantiate(prefabToCreate, parentObject.transform);
        newObject.transform.localPosition = Vector3.zero;
    }
}
