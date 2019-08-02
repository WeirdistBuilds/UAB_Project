using UnityEngine;
using UnityEngine.UI;

public class FullScreenSprite : MonoBehaviour
{
    private float cameraHeight;
    private Vector2 cameraSize;
    private Vector2 imageSize;
    private Vector2 scale;
    private RectTransform rectTransform;
    
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        cameraHeight = Camera.main.orthographicSize * 2;
        cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
        imageSize = rectTransform.sizeDelta;
        
        scale = rectTransform.localScale;
        if (cameraSize.x >= cameraSize.y)
        {
            scale *= cameraSize.x / imageSize.x;
        } 
        else
        {
            scale *= cameraSize.y / imageSize.y;
        }
    }
}
