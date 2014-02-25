﻿/*
 * @author Valentin Simonov / http://va.lent.in/
 */

using UnityEngine;

namespace TouchScript
{
    [AddComponentMenu("TouchScript/Gesture Manager")]
    public sealed class GestureManager : MonoBehaviour
    {
        #region Public properties

        public static IGestureManager Instance { get { return GestureManagerInstance.Instance; } }

        #endregion

    }
}