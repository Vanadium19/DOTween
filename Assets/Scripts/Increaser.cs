using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Increaser : MonoBehaviour
{
    [SerializeField] private float _multiplier;
    [SerializeField] private float _duration;

    private int _loopCount = -1;

    private void Start()
    {
        transform.DOScale(_multiplier * transform.localScale, _duration).SetLoops(_loopCount, LoopType.Yoyo).SetEase(Ease.Linear);    
    }
}
