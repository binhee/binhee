using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // event �ܺο��� ȣ������ ���ϰ� ���´�
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    // ĳ���� �̵� �̺�Ʈ ȣ�� �޼���
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    // ĳ���� �ü� �̵� �̺�Ʈ ȣ�� �޼���
    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
