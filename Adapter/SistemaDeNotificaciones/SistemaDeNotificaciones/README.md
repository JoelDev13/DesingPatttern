# 🧩 Ejercicio Práctico: Patrón de Diseño Adapter (Aplicado con IA)

Este proyecto demuestra el uso del patrón de diseño **Adapter** en C# 
Fue realizado como parte de mi aprendizaje guiado por inteligencia artificial (IA)

---

## 📘 Descripción del ejercicio

El objetivo era **unificar el uso de servicios de notificación** incompatibles mediante el uso del patrón **Adapter**, permitiendo que un sistema cliente trabaje con una interfaz común sin necesidad de modificar el código original de los servicios.

---

## 🔧 Estructura del código

### 🧠 Clases generadas por la IA (base del ejercicio):
- `CloudPushService`: Clase que representa un servicio de notificaciones en la nube. Contiene un método propio para enviar mensajes.
- `INotificationService`: Interfaz común esperada por el cliente, con un método `EnviarNotificacion(string mensaje)`.

Estas clases me fueron proporcionadas por la IA como base para aplicar el patrón Adapter

---

### 💻 Clase implementada por mí (el Adapter):

- `CloudPushNotificationAdapter`: Esta clase **implementa la interfaz `INotificationService`** y adapta internamente a `CloudPushService`.  
  Gracias a este adaptador, el cliente puede utilizar `CloudPushService` como si fuera un `INotificationService`, sin acoplarse a su implementación real

---

## 📚 Prompt utilizado para el aprendizaje guiado

El siguiente prompt fue recomendado por mi profesor para lograr un entendimiento profundo del patrón Adapter:

> “Eres un arquitecto de software experto y un formador técnico. Estoy estudiando el patrón de diseño Adapter y necesito comprenderlo a fondo, más allá de su definición básica. Por favor, explícamelo de forma clara y estructurada, incluyendo:  
> - Una explicación detallada de qué problema resuelve este patrón y por qué es útil en aplicaciones reales.  
> - La diferencia entre el Adapter de clase y el Adapter de objeto, con un ejemplo simple de cada uno (en pseudocódigo o C#).  
> - Un ejercicio práctico de aplicación: preséntame una situación funcional donde deba implementar el patrón Adapter para permitir que un componente existente incompatible funcione con uno nuevo. Dame la consigna, el contexto y el objetivo del ejercicio.  
> - Una vez realice el ejercicio, te mostraré mi solución para recibir retroalimentación sobre cómo mejorarla.”

---


