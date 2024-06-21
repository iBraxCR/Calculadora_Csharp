## Calculadora de Consola en C#

### Descripción

Este programa es una calculadora simple en C# que permite al usuario realizar operaciones básicas de suma, resta y división. El programa presenta un menú de opciones, solicita la entrada de dos números y muestra el resultado de la operación seleccionada.

### Estructura del Proyecto

El proyecto está compuesto por dos archivos principales:

1. **Program.cs**: Contiene la lógica principal del programa, incluyendo el menú y la validación de las entradas del usuario.
2. **Menu.cs**: Contiene la clase `Menu`, que maneja la lógica de las operaciones matemáticas basadas en la selección del usuario.

### Cómo Ejecutar el Programa

1. **Compilación**: Compile el programa utilizando un entorno de desarrollo compatible con C# (como Visual Studio) o mediante la línea de comandos utilizando el compilador `csc`.
2. **Ejecución**: Ejecute el programa compilado. Aparecerá un menú en la consola con las siguientes opciones:
   ```
   Seleccione una opción:
   1. Suma
   2. Resta
   3. División
   4. Salir
   ```

3. **Selección de Opción**: Ingrese un número del 1 al 4 para seleccionar la operación deseada:
   - `1`: Suma
   - `2`: Resta
   - `3`: División
   - `4`: Salir del programa

4. **Ingreso de Números**: Después de seleccionar una operación (excepto salir), ingrese los dos números cuando se le solicite.

### Ejemplo de Uso

1. Ejecutar el programa.
2. Seleccionar la opción `1` para suma.
3. Ingresar `5` como primer número.
4. Ingresar `3` como segundo número.
5. El programa mostrará:
   ```
   Resultado de la suma: 8
   ```

### Manejo de Errores

- Si se ingresa una opción no válida en el menú (cualquier número que no sea del 1 al 4), el programa mostrará un mensaje de error y solicitará nuevamente la entrada.
- Si los números ingresados no son válidos (no se pueden convertir a enteros), el programa mostrará un mensaje de error y solicitará nuevamente la entrada.
- En la operación de división, si el segundo número es `0`, el programa mostrará un mensaje indicando que no se puede dividir por cero.


### Contribuciones

Las contribuciones son bienvenidas. Si encuentras algún error o deseas agregar nuevas funcionalidades, por favor, abre un "issue" o envía un "pull request".
