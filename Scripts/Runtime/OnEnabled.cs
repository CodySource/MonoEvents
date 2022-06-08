using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CodySource
{
    public class OnEnabled : MonoBehaviour
    {
        public UnityEvent onTrigger = new UnityEvent();
        private void OnEnable () => onTrigger?.Invoke();
    }
}