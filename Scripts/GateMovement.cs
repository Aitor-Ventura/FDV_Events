using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GateMovement : MonoBehaviour
{
    public void MoveGate()
    {
        transform.DOMove(new Vector3(
            transform.position.x,
            transform.position.y - 5f,
            transform.position.z), 2f, false);
    }
}
