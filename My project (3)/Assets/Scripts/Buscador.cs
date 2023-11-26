using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Buscador : MonoBehaviour
{
    private Texture2D texture;
    public Image imageObject;
    public static string imagePath;

    public void OpenImageExplorer()
    {
        imagePath = UnityEditor.EditorUtility.OpenFilePanel("Seleccionar imagen", "", "png,jpg,jpeg");
        if (!string.IsNullOrEmpty(imagePath))
        {
            Debug.Log("Ruta de la imagen seleccionada: " + imagePath);
            // Utiliza la ruta de la imagen seleccionada como necesites
            Texture2D.Destroy(texture);
            texture = new Texture2D(1, 1);
            byte[] pcxFile = File.ReadAllBytes(imagePath);
            texture.LoadImage(pcxFile);
            imageObject.GetComponent<Image>().sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        }
    }
}