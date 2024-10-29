using UnityEngine;
using DG.Tweening;

public class PopupEffect : MonoBehaviour
{
    [SerializeField] private float duration = 0.5f;   // Duración del efecto de pop
    [SerializeField] private float scaleFactor = 1f; // Escalado máximo durante el pop
    private Vector3 originalScale;

    private void OnEnable()
    {
        originalScale = transform.localScale; // Guardamos el tamaño original
        ShowPopup();
    }

    public void ShowPopup()
    {
        // Reiniciamos el tamaño y aplicamos el efecto de pop
        transform.localScale = Vector3.zero;
        transform.DOScale(originalScale * scaleFactor, duration / 2)
                 .SetEase(Ease.OutBack) // Suavizado de entrada
                 .OnComplete(() => transform.DOScale(originalScale, duration / 2)
                 .SetEase(Ease.InBack)); // Suavizado de salida al tamaño original
    }
}
