using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CodySource
{
    public class OnDisabled : MonoBehaviour
    {
        public UnityEvent onTrigger = new UnityEvent();
        private void OnDisable () => onTrigger?.Invoke();
    }
}