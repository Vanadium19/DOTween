using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration;

    private int _loopCount = -1;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration).SetLoops(_loopCount, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
