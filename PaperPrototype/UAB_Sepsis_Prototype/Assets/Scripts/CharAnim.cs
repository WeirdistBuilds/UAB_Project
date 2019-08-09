using UnityEngine;
using UnityEngine.UI;

public class CharAnim : MonoBehaviour
{
    public float fps = 30.0f;
    public Sprite[] frames;

    private int frameIndex;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
        NextFrame();
        InvokeRepeating("NextFrame", 1 / fps, 1 / fps);
    }

    void NextFrame()
    {
        image.sprite = frames[frameIndex];
        if (frameIndex >= frames.Length - 1)
        {
            frameIndex = 0;
        }
        else
        {
            frameIndex++;
        }
    }
}
