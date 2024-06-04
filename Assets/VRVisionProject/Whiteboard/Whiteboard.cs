using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;



public class Whiteboard : MonoBehaviour
{


    public XRBaseController leftController;
    public XRBaseController rightController;

    public Texture2D texture;
    public Vector2 textureSize = new Vector2(2048, 2048);

    // Start is called before the first frame update
    void Start()
    {
        var r = GetComponent<Renderer>();
        texture = new Texture2D((int)textureSize.x, (int)textureSize.y);
        r.material.mainTexture = texture;
    }

    public void resetBoard()
    {
        var r = GetComponent<Renderer>();
       // Texture2D texture = new Texture2D((int)textureSize.x, (int)textureSize.y);

       
        Color32[] greyPixels = new Color32[texture.width * texture.height];
        Color32 grey = new Color32(192, 192, 192, 255); 
        for (int i = 0; i < greyPixels.Length; i++)
        {
            greyPixels[i] = grey;
        }
        texture.SetPixels32(greyPixels);

        texture.Apply();

        r.material.mainTexture = texture;
    }
}
