# INTRODUCCI�N A UNITY 2D - SPRITES

El primer paso es crear la animaci�n de Walk Down. Se agrega el atlas de sprites para generar la animaci�n, se seleccionan los sprties que se usar�n para realizar la animaci�n y se le agrega al objeto de la escena. 

![Esquema animator](Imagenes/p2_imagen_walkdown.png)
![sprite](Imagenes/walkdown.gif)

Ahora se colocan los sprites que har�n la animacion de movimiento de derecha a izquierda. Se crea una variable publica que determina la velocidad de movimiento. En el update se captura un valor horizontal de 1 a -1. Luego, se crea un vector de movimiento en el eje X y mueve el objeto con una velocidad y movimiento fluido. 

![C�digo](Imagenes/p2_imagen1_movimientohorizontal.png)

Adem�s, el sprite que tengo solo tiene una orientaci�n en el sentido izquierdo. Se necesita que el sprite se oriente en la direcci�n de movimiento. 

![C�digo](Imagenes/p2_spriterenderer.png)

Con SpriteRenderer se modifica el sprite. SpriteRenderer.flipX voltea el sprite. Si el valor horizontal es mayor que 0, es que va a la derecha por lo que se activa el volteo. Si es menor que 0 se deja como est�.

![sprite](Imagenes/spriterender.gif)

El sprite ya se orienta. Sin embargo, se puede ver que las animaciones puestas se repiten en bucle. En el animator hay una transici�n que va desde idle al movimiento horizontal. El siguiente paso ser�a asignar la animaci�n al movimiento. Cuando camine solo realizar� la animaci�n correspondiente. Para ello, se crea una variable booleana "isWalking" que se asociara a la transici�n entre idle y move_left.

![C�digo](Imagenes/p2_animatorsetbool.png)

Primero se obtiene el componente animator y en el update se determina que si el valor horizontal no es 0, es que se mueve, por lo que se activa la variable "isWalking". Si es 0 no se activa por lo que se activa la animaci�n de reposo.

![Sprite](Imagenes/animator.gif)

Por �ltimo, hay que crear un nuevo script en que, despu�s de caminar una distancia, cambie la animaci�n. 

![C�digo](Imagenes/p2_partefinal.png)

Primero se declaran nuevas variables como la distancia recorrida,  distancia para el cambio de animaci�n, la posici�n de inicio y la distancia actualizada en el frame. Para ello hay que llamar al animator y tamb�en determinar la posici�n de inicio desde un comienzo. En el Update se calcula la distancia en el frame calculando la diferencia entre la posicion de inicio y la nueva posici�n. Esa ser� la distancia recorrida. Creamos una nueva variable booleana para la nueva animaci�n. Si la distancia recorrida es mayor o igual que la que se le pide para el cambio de animaci�n, se activa la variable. Si no, no se activa.

![Sprite](Imagenes/partefinal.gif)

El animator quedar�a as�:

![Animator](Imagenes/animatorfinal.png)





