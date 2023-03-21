using UnityEngine;

public class DoorController : MonoBehaviour
{
    // ������ �� ��������� Animator �� �����.
    private Animator doorAnimator;

    private void Start()
    {
        // �������� ������ �� ��������� Animator �� �����.
        doorAnimator = GetComponent<Animator>();
    }

    // ����������, ����� ����� ��������� �� ���������.
    public void OnStoveTriggerEnter()
    {
        // ���������� ������� �������� �� �����, ����� ������� ��.
        doorAnimator.SetTrigger("Open");
    }

    // ����������, ����� ����� �������� ���������.
    public void OnStoveTriggerExit()
    {
    }
}
