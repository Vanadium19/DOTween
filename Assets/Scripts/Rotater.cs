using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private Vector3 _targetRotation;
    [SerializeField] private float _duration;

    private int _loopCount = -1;

    private void Start()
    {
        transform.DORotate(_targetRotation, _duration).SetLoops(_loopCount, LoopType.Restart).SetEase(Ease.Linear);
    }
}
