using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private Camera _camera;

    private void Awake()
    {
        // Awake 메서드에서 메인 카메라를 가져옵니다.
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        // 이동 입력을 받아서 정규화한 벡터로 변환합니다.
        Vector2 moveInput = value.Get<Vector2>().normalized;
        // 이동 이벤트 호출합니다.
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        // 시선 이동 입력을 받아서 화면 좌표를 월드 좌표로 변환합니다.
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        // 시선 벡터의 크기가 0.9 이상이면 시선 이벤트 호출합니다.
        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        // 발사 입력을 처리하는 메서드입니다.
        // 현재는 빈 메서드입니다. 발사 로직을 여기에 구현하세요.
    }

    // 이동 이벤트 호출을 담당하는 메서드
    private void CallMoveEvent(Vector2 moveInput)
    {
        // 이동 이벤트 호출 로직을 여기에 추가하세요.
    }

    // 시선 이벤트 호출을 담당하는 메서드
    private void CallLookEvent(Vector2 aimDirection)
    {
        // 시선 이벤트 호출 로직을 여기에 추가하세요.
    }
}