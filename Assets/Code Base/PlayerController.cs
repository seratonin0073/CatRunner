using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isGrounded = false;
    private Rigidbody2D rb2d;//змінна що зберігає фізику об'єкта
    [SerializeField] private float jumpStrength = 3f; //поле яке зберігає швидкість руху
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();//отримуємо фізику об'кта
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isGrounded) Jump();
    }

   void Jump()
   {
       rb2d.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);//даємо імпульс нашому об'єкту
       isGrounded = false;//об'єкт не на землі
   }

   private void OnCollisionEnter2D(Collision2D other)
   {
       //якщо доторкнулись до об'єкта який має тег Ground то змінна isGrounded = true
       if (other.gameObject.CompareTag("Ground")) isGrounded = true;
   }
}


