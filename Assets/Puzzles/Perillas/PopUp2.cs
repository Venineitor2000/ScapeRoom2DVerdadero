using UnityEngine;
using DG.Tweening;

public class PopUp2 : MonoBehaviour
{
    [SerializeField] private float duration = 0.5f;   // Duración del efecto de pop
    [SerializeField] private float scaleFactor = 1f; // Escalado máximo durante el pop
    private Vector2 originalScale;
    public RectTransform rect;


    private void OnEnable()
    {
        originalScale = rect.localScale; // Guardamos el tamaño original
        ShowPopup();
    }

    public void ShowPopup()
    {
        // Reiniciamos el tamaño y aplicamos el efecto de pop
        rect.localScale = Vector3.zero;
        rect.DOScale(originalScale * scaleFactor, duration / 2)
                 .SetEase(Ease.OutBack) // Suavizado de entrada
                 .OnComplete(() => rect.DOScale(originalScale, duration / 2)
                 .SetEase(Ease.InBack)); // Suavizado de salida al tamaño original
    }
}
