using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [SerializeField] private float levelSpeed = 1f;

    public float LevelSpeed
    {
        get { return levelSpeed; }
    }


    void FixedUpdate()
    {
        transform.Translate(Vector2.left * levelSpeed * Time.fixedDeltaTime);
        if (transform.position.x <= -4) transform.position = new Vector2(5, -4.5f);
    }
}
