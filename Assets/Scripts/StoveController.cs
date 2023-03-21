using UnityEngine;

public class StoveController : MonoBehaviour
{
    // Ссылка на дверь, которую нужно открывать.
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что объект входящий в триггер имеет тег "Player".
        if (other.CompareTag("Player"))
        {
            // Отправляем сообщение о том, что игрок на платформе, двери door.
            door.SendMessage("OnStoveTriggerEnter");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Проверяем, что объект выходящий из триггера имеет тег "Player".
        if (other.CompareTag("Player"))
        {
            // Отправляем сообщение о том, что игрок покинул платформу, двери door.
            door.SendMessage("OnStoveTriggerExit");
        }
    }
}