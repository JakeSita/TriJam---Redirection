using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{

   public class DamageFlash : MonoBehaviour
   {
      [SerializeField] private Color _flashColor = Color.white;
      [SerializeField] private float _flashDuration = 1f;
      private SpriteRenderer _spriteRenderer;
      private Material _defaultMaterial;
      private Coroutine _flashCoroutine;

      public void Awake()
      {
         _spriteRenderer = GetComponent<SpriteRenderer>();
         Init();
      }

      public void Init()
      {
         _defaultMaterial = new Material(_spriteRenderer.material);
      }

      public void TriggerDamageFlash()
      {
         if (_flashCoroutine != null)
         {
            StopCoroutine(_flashCoroutine);
         }

         _flashCoroutine = StartCoroutine(Flash());
      }

      private IEnumerator Flash()
      {
         _defaultMaterial.SetColor("_FlashColor", _flashColor);
         float elapsedTime = 0;
         while (elapsedTime < _flashDuration)
         {
            elapsedTime += Time.deltaTime;
            float flashAmount = Mathf.Lerp(1f, 0f, elapsedTime / _flashDuration);
            SetFlashAmount(flashAmount);
            yield return null;
         }

         _flashCoroutine = null;
      }

      private void SetFlashAmount(float flashAmount)
      {
         _defaultMaterial.SetFloat("_FlashAmount", flashAmount);
      }
   }
}