# Biblioteca

## Entrega 03: Estructura de clases

La tercera entrega debe preparar (casi toda) la estructura de clases básica del proyecto:

- La clase principal será la clase Biblioteca, con un único método Ejecutar. 
Este método mostrará un menú principal con 4 opciones:

```
1. Gestión de libros
2. Gestión de usuarios
3. Gestión de préstamos
0. Salir
```

- Existirá una clase GestionDeLibros, de modo que si el usuario escoge la 
opción 1 en el menú principal, se creará un objeto de esta clase, y se llamará 
a su método Ejecutar, que corresponderá a lo que era el "Main" de la entrega 
anterior.

- El nuevo Main de la aplicación estará en la clase Biblioteca, y se limitará a 
crear un objeto de la clase Biblioteca y llamar al método Ejecutar.

- Existirá una clase GestionDeUsuarios, de modo que si el usuario escoge la 
opción 2 en el menú principal, se creará un objeto de esta clase, y se llamará 
a su método Ejecutar, que sólo mostrará el texto "(Pronto disponible)" y 
esperará a que el usuario pulse una tecla.

- Existirá una clase GestionDePrestamos, de modo que si el usuario escoge la 
opción 3 en el menú principal, se creará un objeto de esta clase, y se llamará 
a su método Ejecutar, que sólo mostrará el texto "(Pronto disponible)" y 
esperará a que el usuario pulse una tecla.

- Además existirán otras 4 clases que todavía estarán vacías y que se 
completarán más adelante: Usuario, ListaDeUsuarios, Prestamo, 
ListaDePrestamos. 
