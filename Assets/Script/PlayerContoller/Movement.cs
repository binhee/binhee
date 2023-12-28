using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // CharacterController ��ũ��Ʈ ���� ����
    private CharacterController _controller;
    // �̵� ����
    private Vector2 _movementDirection = Vector2.zero;
    // Rigidbody2D ������Ʈ ���� ����
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        // CharacterController ������Ʈ ��������
        _controller = GetComponent<CharacterController>();
        // Rigidbody2D ������Ʈ ��������
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // �̵� �̺�Ʈ�� Move �޼��� ���
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // �̵� ���� �޼��� ȣ��
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // �̵� �̺�Ʈ�� ���� ���� �������� �����ϴ� �޼���
        _movementDirection = direction;
    }

    // ���� �̵��� �����ϴ� �޼���
    private void ApplyMovment(Vector2 direction)
    {
        // �̵� ���⿡ ����� ���Ͽ� �ӵ� ����
        direction = direction * 5;

        // Rigidbody2D�� �ӵ��� �����Ͽ� �̵� ����
        _rigidbody.velocity = direction;
    }
}
