using UnityEngine;

public class oyuncuHareket : MonoBehaviour
{
    public float hiz = 8f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(yatay * hiz, rb.linearVelocity.y);
    }

    // Altına temas edildiğinde çalışacak kısım:
    private void OnTriggerEnter2D(Collider2D diger)
    {
        // Temas edilen objenin adı "Altin" ise
        if (diger.gameObject.name == "Altin")
        {
            Destroy(diger.gameObject); // Altını sahneden sil!
            Debug.Log("Altın Toplandı! 🎉");
        }
    }
}