using UnityEngine;

public class DoorController2 : MonoBehaviour
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
        doorAnimator.SetTrigger("Open2");
    }

    // ����������, ����� ����� �������� ���������.
    public void OnStoveTriggerExit()
    {
    }
}