using UnityEngine;

public class Bar : MonoBehaviour
{
    [Range(0.01f, 1f)]
    public float width;

    [Range(1,9)]
    public int height;
    
    // Debug purposes

    public void UpdateWidth(float newWidth)
    {
        Vector3 newScale = transform.localScale;
        newScale.x = newWidth;
        transform.localScale = newScale;
    }

    public void UpdateHeight(float newHeight)
    {
        Vector3 newScale = transform.localScale;
        newScale.y = newHeight;
        transform.localScale = newScale;
    }

}
