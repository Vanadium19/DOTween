using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Painter : MonoBehaviour
{    
    [SerializeField] private float _duration;

    private MeshRenderer _meshRenderer;
    private int _loopCount = -1;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();           
    }

    private void Start()
    {
        _meshRenderer.material.DOColor(Color.red, _duration).SetLoops(_loopCount, LoopType.Yoyo).SetEase(Ease.Linear);        
    }
}
