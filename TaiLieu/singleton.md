[Quay lại trang chính](../README.md)

## Singleton Pattern

> Singleton là mẫu thiết kế sáng tạo đảm bảo một lớp chỉ có một instance, và cung cấp điểm truy cập toàn cục đến nó.

Hình minh họa cấu trúc UML

<img width="924" height="413" alt="image" src="https://github.com/user-attachments/assets/b028ac56-bbbe-4721-beb8-2155aa758036" />

Singleton ngăn chặn việc tạo nhiều instance và cung cấp truy cập dễ dàng.

Ví dụ Chocolate Boiler trong Head First

```csharp
public class ChocolateBoiler
{
    private static ChocolateBoiler _uniqueInstance;
    private bool _empty;
    private bool _boiled;

    private ChocolateBoiler()
    {
        _empty = true;
        _boiled = false;
    }

    public static ChocolateBoiler GetInstance()
    {
        if (_uniqueInstance == null)
        {
            _uniqueInstance = new ChocolateBoiler();
        }
        return _uniqueInstance;
    }

    public void Fill()
    {
        if (_empty)
        {
            _empty = false;
            _boiled = false;
            // fill the boiler with a milk/chocolate mixture
        }
    }

    public void Drain()
    {
        if (!_empty && _boiled)
        {
            // drain the boiled milk and chocolate
            _empty = true;
        }
    }

    public void Boil()
    {
        if (!_empty && !_boiled)
        {
            // bring the contents to a boil
            _boiled = true;
        }
    }
}
```

Cách sử dụng

```csharp
ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
boiler.Fill();
boiler.Boil();
boiler.Drain();
```
