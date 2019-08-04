using UnityEngine;

public class FullScreenSprite : MonoBehaviour
{
    private float cameraHeight;
    private Vector2 cameraSize;
    private Vector2 spriteSize;
    private Vector2 scale;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cameraHeight = Camera.main.orthographicSize * 2;
        cameraSize = new Vector2(Camera.main.aspect * cameraHeight, cameraHeight);
        spriteSize = spriteRenderer.sprite.bounds.size;
        
        scale = transform.localScale;
        if (cameraSize.x >= cameraSize.y)
        {
            scale *= cameraSize.x / spriteSize.x;
        } 
        else
        {
            scale *= cameraSize.y / spriteSize.y;
        }
        
        transform.position = Vector2.zero;
        transform.localScale = scale;
    }
}
