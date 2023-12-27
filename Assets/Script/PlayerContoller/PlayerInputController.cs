using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private Camera _camera;

    private void Awake()
    {
        // Awake �޼��忡�� ���� ī�޶� �����ɴϴ�.
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        // �̵� �Է��� �޾Ƽ� ����ȭ�� ���ͷ� ��ȯ�մϴ�.
        Vector2 moveInput = value.Get<Vector2>().normalized;
        // �̵� �̺�Ʈ ȣ���մϴ�.
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        // �ü� �̵� �Է��� �޾Ƽ� ȭ�� ��ǥ�� ���� ��ǥ�� ��ȯ�մϴ�.
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        // �ü� ������ ũ�Ⱑ 0.9 �̻��̸� �ü� �̺�Ʈ ȣ���մϴ�.
        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        // �߻� �Է��� ó���ϴ� �޼����Դϴ�.
        // ����� �� �޼����Դϴ�. �߻� ������ ���⿡ �����ϼ���.
    }

    // �̵� �̺�Ʈ ȣ���� ����ϴ� �޼���
    private void CallMoveEvent(Vector2 moveInput)
    {
        // �̵� �̺�Ʈ ȣ�� ������ ���⿡ �߰��ϼ���.
    }

    // �ü� �̺�Ʈ ȣ���� ����ϴ� �޼���
    private void CallLookEvent(Vector2 aimDirection)
    {
        // �ü� �̺�Ʈ ȣ�� ������ ���⿡ �߰��ϼ���.
    }
}