# Kogane IDisposable Add To Extension Methods

IDisposable の AddTo 拡張メソッド

## 使用例

```csharp
using System;
using Kogane;
using UnityEngine;

public class Test : IDisposable
{
    public void Dispose()
    {
        Debug.Log( "Complete" );
    }
}

public class Example : MonoBehaviour
{
    private void Awake()
    {
        new Test().AddTo( gameObject );
        new Test().AddTo( this );
    }
}
```