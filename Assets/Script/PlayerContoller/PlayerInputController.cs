using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController
{
    private Camera _camera;

    private void Awake()
    {
        // Awake �޼��忡�� ���� ī�޶� ������
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        // �̵� �Է��� �޾Ƽ� ����ȭ�� ���ͷ� ��ȯ
        Vector2 moveInput = value.Get<Vector2>().normalized;
        // �̵� �̺�Ʈ ȣ��
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        // ���콺 �ü� �̵� �Է��� �޾Ƽ� ȭ�� ��ǥ�� ���� ��ǥ�� ��ȯ
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        // �ü� ������ ũ�Ⱑ 0.9 �̻��̸� �ü� �̺�Ʈ ȣ��
        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        // �߻� �Է��� ó���ϴ� �޼���
        // ����� �� �޼��� �߻� ������ ���⿡ �����ϼ���.
    }    
}