using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // CharacterController 스크립트 참조 변수
    private CharacterController _controller;
    // 이동 방향
    private Vector2 _movementDirection = Vector2.zero;
    // Rigidbody2D 컴포넌트 참조 변수
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        // CharacterController 컴포넌트 가져오기
        _controller = GetComponent<CharacterController>();
        // Rigidbody2D 컴포넌트 가져오기
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // 이동 이벤트에 Move 메서드 등록
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // 이동 적용 메서드 호출
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // 이동 이벤트를 통해 받은 방향으로 설정하는 메서드
        _movementDirection = direction;
    }

    // 실제 이동을 적용하는 메서드
    private void ApplyMovment(Vector2 direction)
    {
        // 이동 방향에 상수를 곱하여 속도 조절
        direction = direction * 5;

        // Rigidbody2D의 속도를 설정하여 이동 적용
        _rigidbody.velocity = direction;
    }
}
