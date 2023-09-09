using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 direction; //поле яке зберігає напрям руху
    private float speed = 3.2f; //поле яке зберігає швидкість руху
    void Start()
    {
        Debug.Log("Hello Unity!");
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal"); // отримуємо значення з клавіш керування (Horizontal вісь)
        direction.y = Input.GetAxis("Vertical"); // отримуємо значення з клавіш керування (Vertical вісь)
        transform.Translate(direction.normalized * speed * Time.deltaTime); //метод переміщення об'єкту
    }
}
