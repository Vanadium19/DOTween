using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private string _startText;
    [SerializeField] private string _additionalText;
    [SerializeField] private string _scrambledText;

    private Sequence _sequence;
    private Text _text;
    private int _loopCount = -1;

    private void Awake()
    {
        _text = GetComponent<Text>();
        _sequence = DOTween.Sequence();
    }   

    private void Start()
    {
        _sequence.Append(_text.DOText(_startText, _duration))
            .Append(_text.DOColor(Color.green, _duration))
            .Append(_text.DOText(_additionalText, _duration).SetRelative())
            .Append(_text.DOColor(Color.red, _duration))
            .Append(_text.DOText(_scrambledText, _duration, true, ScrambleMode.All))
            .Append(_text.DOFade(0, _duration))
            .SetLoops(_loopCount, LoopType.Restart);
    }
}
