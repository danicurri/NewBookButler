# Biblioteca

## Entrega 02: Clases Libro y ListaDeLibros

En vez del "struct" que representa los datos de un libro, deberás crear una 
clase "Libro", que contendrá esos mismos atributos además de un código 
alfanumérico (que hará la misma función que haría una "clave primaria"), los 
correspondientes Get/Set y un (único) constructor que dé valor a todos los 
atributos. Los getters y setters pueden seguir el estilo clásico, o bien ser 
propiedades de C#.

Además, deberás crear una clase "ListaDeLibros", que todavía puede ser 
internamente un array de libros (para no cambiar mucho la estructura de la 
entrega anterior) o bien una lista de libros, si lo prefieres. Para poder 
imitar la funcionalidad de la versión anterior, esta clase tendrá un método 
"Get(n)", que devuelva el libro que hay en una cierta posición, una propiedad 
"Cantidad" que devuelva la cantidad de libros existentes y un método 
"Incluir(libro)" que añada un libro a la estructura de datos existente.

El funcionamiento de la aplicación deberá ser exactamente igual que el de la 
primera version, para lo que la clase "ListaDeLibros" deberá tener un método 
privado para cargar los datos desde fichero y otro método privado para guardar 
los datos en fichero, y además el constructor de ListaDeLibros deberá llamar al 
método Cargar y el método Incluir deberá llamar a Guardar.
