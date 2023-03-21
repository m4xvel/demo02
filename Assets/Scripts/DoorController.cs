using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Ссылка на компонент Animator на двери.
    private Animator doorAnimator;

    private void Start()
    {
        // Получаем ссылку на компонент Animator на двери.
        doorAnimator = GetComponent<Animator>();
    }

    // Вызывается, когда игрок находится на платформе.
    public void OnStoveTriggerEnter()
    {
        // Активируем триггер анимации на двери, чтобы открыть ее.
        doorAnimator.SetTrigger("Open");
    }

    // Вызывается, когда игрок покидает платформу.
    public void OnStoveTriggerExit()
    {
    }
}
