using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkingSpawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject _rightMarkingPrefab;
    [SerializeField] 
    private GameObject _leftMarkingPrefab;

    private float _markingStep;

    private void Awake()
    {
        _markingStep = 100 * _rightMarkingPrefab.transform.localScale.x + 100 * _rightMarkingPrefab.transform.localScale.x / 3;
        var numberOfMarkings = CalculationNumberOfMarkings();
        for (int i = 0; i < numberOfMarkings; i++)
        {
            var rightMarking = Instantiate(_rightMarkingPrefab, gameObject.transform);
            var leftMarking = Instantiate(_leftMarkingPrefab, gameObject.transform);
            var positionRight = rightMarking.transform.position;
            positionRight.x += _markingStep * i - 500;
            rightMarking.transform.position = positionRight;
            var positionLeft = leftMarking.transform.position;
            positionLeft.x += _markingStep * i - 500;
            leftMarking.transform.position = positionLeft;
        }
    }

    private int CalculationNumberOfMarkings()
    {
        var numberOfMarkings = (int)Mathf.Round(transform.localScale.x * 10 / _markingStep);
        return numberOfMarkings;
    }
}
