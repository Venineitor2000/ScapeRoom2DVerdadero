using UnityEngine;
using DG.Tweening;

public class PopupEffect : MonoBehaviour
{
    [SerializeField] private float duration = 0.5f;   // Duraci�n del efecto de pop
    [SerializeField] private float scaleFactor = 1f; // Escalado m�ximo durante el pop
    private Vector3 originalScale;

    private void OnEnable()
    {
        originalScale = transform.localScale; // Guardamos el tama�o original
        ShowPopup();
    }

    public void ShowPopup()
    {
        // Reiniciamos el tama�o y aplicamos el efecto de pop
        transform.localScale = Vector3.zero;
        transform.DOScale(originalScale * scaleFactor, duration / 2)
                 .SetEase(Ease.OutBack) // Suavizado de entrada
                 .OnComplete(() => transform.DOScale(originalScale, duration / 2)
                 .SetEase(Ease.InBack)); // Suavizado de salida al tama�o original
    }
}
