using UnityEngine;

public class StoveController : MonoBehaviour
{
    // ������ �� �����, ������� ����� ���������.
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ������ �������� � ������� ����� ��� "Player".
        if (other.CompareTag("Player"))
        {
            // ���������� ��������� � ���, ��� ����� �� ���������, ����� door.
            door.SendMessage("OnStoveTriggerEnter");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // ���������, ��� ������ ��������� �� �������� ����� ��� "Player".
        if (other.CompareTag("Player"))
        {
            // ���������� ��������� � ���, ��� ����� ������� ���������, ����� door.
            door.SendMessage("OnStoveTriggerExit");
        }
    }
}