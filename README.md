# Tarea Programada 2 - Calculadora de Triángulos

**Curso:** Programación Avanzada  
**Código:** SC-601  
**Profesor:** Luis Andrés Rojas Matey  
**Estudiante:** Mariana Hidalgo De La O
**Carné:** FH23015127 


## Descripción

Este programa permite ingresar las longitudes de los tres lados de un triángulo y calcular:
- Perímetro y semiperímetro
- Área (usando la fórmula de Herón)
- Tipo de triángulo (Equilátero, Isósceles o Escaleno)
- Ángulos internos (α, β y γ en grados)

---

## Repositorio
https://github.com/mariana044/TP2trigonometria.git

---

## Recursos consultados

- [Stack Overflow](https://stackoverflow.com/)
- [Microsoft Docs - Math.Acos](https://learn.microsoft.com/en-us/dotnet/api/system.math.acos)
- [GeeksForGeeks - Tipos de triángulo](https://www.geeksforgeeks.org/types-of-triangle/)
- [W3Schools C# Validation Attributes](https://www.w3schools.com/cs/cs_validation.aspx)

---

## Prompts de ChatGPT

**Prompt:**  
*¿Cómo valido que tres lados forman un triángulo válido en C# ASP.NET MVC?*  
**Respuesta:**  
Se debe verificar que la suma de dos lados siempre sea mayor al tercer lado, por ejemplo: `if (a + b > c && a + c > b && b + c > a)`

*¿Cómo calculo los ángulos internos de un triángulo en C# si conozco las longitudes de sus tres lados (a, b, c)?  
Quiero usar la fórmula de la ley del coseno y la función Math.Acos para obtener los ángulos en grados.*

**Respuesta:**  
`double alpha = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * (180 / Math.PI);`  
`double beta = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * (180 / Math.PI);`  
`double gamma = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * (180 / Math.PI);`

