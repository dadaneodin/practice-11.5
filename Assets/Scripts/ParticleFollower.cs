using UnityEngine;

public class ParticleFollower : MonoBehaviour
{
    public Transform player; // Ссылка на игрока
    public Vector3 offset = new Vector3(0, 1, 0); // Смещение относительно игрока

    void Update()
    {
        if (player != null)
        {
            // Перемещаем систему частиц к позиции игрока + смещение
            transform.position = player.position + offset;
        }
    }
}