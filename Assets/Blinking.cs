using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Lấy component SpriteRenderer khi bắt đầu
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Bật/tắt renderer liên tục mỗi khung hình để tạo hiệu ứng nhấp nháy
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}