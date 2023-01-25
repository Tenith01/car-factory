using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DG.Tweening;
using UnityEngine;

public class SpawnFeedback : MonoBehaviour
{
    [SerializeField]
    public enum CarType
    {
        Sedan,
        SUV,
        Sports
    }

    void OnEnable()
    {
        // transform.localScale = Vector3.zero;
        // transform.DOScale(1f, 0.5f)
        //     .SetEase(Ease.OutBack)
        //     .OnComplete(() => transform.DOLocalRotate(new Vector3(0, 360, 0), 1f))
        //     .SetEase(Ease.InOutCubic);
        transform.localScale = Vector3.one;
        transform.DOScale(1.3f, 0.4f).SetEase(Ease.OutBounce);
    }

    private void OnDestroy()
    {
        transform.localScale = Vector3.one;
        transform.DOScale(0f, 1f)
            .SetEase(Ease.InBack)
            .OnComplete(() => Destroy(this.gameObject));
    }
}