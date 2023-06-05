using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool hasPackedge = false;
    [SerializeField]private float destroyDeplay = 0.5f;
    [SerializeField]private Color32 hasPackedgeColor = new Color32(1, 1, 1, 255);
    [SerializeField] private Color32 hasNoPackedgeColor = new Color32(155, 155, 1, 255);

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Packedge" && !hasPackedge)
        {
            hasPackedge = true;
            Destroy(collision.gameObject, destroyDeplay);
            spriteRenderer.color = hasPackedgeColor;
            Debug.Log("Picked Up");
        }

        if (collision.tag == "Customer" && hasPackedge)
        {
            hasPackedge = false;
            spriteRenderer.color = hasNoPackedgeColor;
            Debug.Log("Dropped Off");
        }

    }

}
