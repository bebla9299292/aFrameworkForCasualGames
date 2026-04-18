using UnityEngine;
public class cube : MonoBehaviour
{
    public GameObject Objectcube;
    public void Move()
    {
        Objectcube.transform.Translate(0, 5, 0); // Просто сдвигаем дверь вверх
        Debug.Log("Дверь открыта!");
    }
}