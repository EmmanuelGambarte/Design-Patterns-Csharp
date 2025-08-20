# ✅ Principio SOLID: Open/Closed Principle (OCP)

Este ejemplo muestra cómo aplicar el **Principio de Abierto/Cerrado (Open/Closed)**, el cual establece que:

> "Las clases deben estar abiertas para la extensión, pero cerradas para la modificación."

---

## ❌ Problema

En el ejemplo original, la clase `Presentacion` tiene un método distinto para cada tipo de figura:

```Csharp
public void area(Rectangulo r) { ... }
public void area(Triangulo t) { ... }
```

Cada vez que queremos agregar una nueva figura (como un Círculo), debemos modificar esta clase. Esto viola el principio OCP.

✅ Solución
Creamos una interfaz IFigura con el método area(). Luego, cada figura implementa esta interfaz (RectanguloOC, TrianguloOC).

```Csharp
public interface IFigura {
    float area();
}
```
La clase PresentacionOC ahora trabaja con la interfaz, y no necesita modificarse si agregamos más figuras.

🧩 Estructura del código

OpenClose/
├── Presentacion.cs          # Violación del OCP
├── Rectangulo.cs            # Figura sin OCP
├── Triangulo.cs             # Figura sin OCP
├── IFigura.cs               # Interfaz para cumplir con OCP
├── PresentacionOC.cs        # Aplica correctamente OCP
├── RectanguloOC.cs          # Figura que implementa IFigura
└── TrianguloOC.cs           # Figura que implementa IFigura

💡 Conclusión
Gracias al uso de una interfaz común (IFigura), las clases consumidoras como PresentacionOC no requieren modificaciones para admitir nuevas figuras. Esto mejora la mantenibilidad y escalabilidad del código.


📚 Referencias
 - O: Open/Closed Principle

 - Parte de los principios SOLID de diseño orientado a objetos.