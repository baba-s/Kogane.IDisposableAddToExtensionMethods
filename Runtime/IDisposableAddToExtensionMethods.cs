using System;
using UnityEngine;

namespace Kogane
{
    public static class IDisposableAddToExtensionMethods
    {
        public static T AddTo<T>( this T self, GameObject gameObject ) where T : IDisposable
        {
            if ( !gameObject.TryGetComponent<DestroyEventListener>( out var listener ) )
            {
                listener = gameObject.AddComponent<DestroyEventListener>();
            }

            listener.OnDestroyed += () => self.Dispose();

            return self;
        }

        public static T AddTo<T>( this T self, Component component ) where T : IDisposable
        {
            return self.AddTo( component.gameObject );
        }
    }
}