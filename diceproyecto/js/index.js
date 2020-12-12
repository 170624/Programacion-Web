
  var posglobalp1;
  var posglobalp2;
  var jugador;
  var y; //variable para que ayuda en la suma de player 1
  var y2; //variable para que ayuda en la suma de player 2
  var dadosimg=new Array()
  var dado1 = document.getElementById("dado1");
  var dado2 = document.getElementById("dado2");
  var dado3 = document.getElementById("dado3");
  var dado4 = document.getElementById("dado4");
  var prueba1 = document.getElementById("prueba1");
  var status2 = document.getElementById("temp2");
  var guardar2 = document.getElementById("movimientos2");
  var guardar = document.getElementById("movimientos");
  dadosimg[0]="img/dice1.png"
  dadosimg[1]="img/dice2.png"
  dadosimg[2]="img/dice3.png"
  dadosimg[3]="img/dice4.png"
  dadosimg[4]="img/dice5.png"
  dadosimg [5]="img/dice6.png"

  nuevojuego();
	  function cambiarjugador() {
      debugger;
      if (posglobalp1 > 99){
        alert("EL juego ha terminado Ganador Player 1");
    }
      if(jugador===1){
        var guardar = document.getElementById("movimientos");
        posglobalp1 =posglobalp1+pos;
        guardar.innerHTML = "Puntos P1:"+ posglobalp1 +".";
 
        prueba1.innerHTML = "Puntos Para Guardar P1:"+ pos +".";
        pos=0;
        jugador=2;
        y=0;
        //var status = document.getElementById("jugador");
        //status.innerHTML = "Jugador:"+ jugador +".";
        return;
      }
   
     
      if(jugador===2){
        posglobalp2 =posglobalp2+pos2;
        guardar2.innerHTML = "Puntos P2:"+ posglobalp2 +".";
   
        status2.innerHTML = "Puntos Para Guardar P2:"+ pos +".";
        pos2=0;
        jugador=1;
        y2=0;
      }
     
      if (posglobalp2 > 99){
        alert("EL juego ha terminado Ganador Player 2");
    
    
    }
	}
	
  function nuevojuego() {
    
     y=0; 
     y2=0;
     jugador=1;
     pos=0;
     pos2=0;
     posglobalp1=0;
     posglobalp2=0;
     guardar2.innerHTML = "Puntos P2:"+ posglobalp2 +".";
     guardar.innerHTML = "Puntos P2:"+ posglobalp2 +".";
     prueba1.innerHTML = "Puntos Para Guardar P1:"+ pos +".";
     status2.innerHTML = "Puntos Para Guardar P2:"+ pos2 +".";
     jugando.innerHTML = "Jugando:"+ jugador +".";
     dado1.innerHTML =  ` `
     dado2.innerHTML =  ` `
     dado3.innerHTML =  `  `
     dado4.innerHTML =  ` `
     
  }

  function girar(){
    if (posglobalp1 > 99){
      alert("EL juego ha terminado Ganador Player 1");

  }
  if (posglobalp2 > 99 ){
    alert("EL juego ha terminado  Ganador Player 2");
  }
    if(jugador===1)
    {
      jugando.innerHTML = "Jugando:"+ jugador +"."; 
      var d1 = Math.floor(Math.random() * 6) + 1;
      var d2 = Math.floor(Math.random() * 6) + 1;
      dado1.innerHTML =  `<img src= "${dadosimg[d1 - 1]}">`
      dado2.innerHTML =  `<img src= "${dadosimg[d2 - 1]}">`
     
      pos=  y + d1 + d2;
      y=pos;
      prueba1.innerHTML = "Puntos Para Guardar P1:"+ pos +".";
   
    
        if(d1 === d2) {
          alert("Dados Dados en Par Para Jugador1  Cambio a Jugador 2");
         pos=0;
         y=0;
         prueba1.innerHTML = "Puntos Para Guardar P1:"+ pos +".";
         posglobalp1 = posglobalp1+pos;
         prueba1.innerHTML = "Puntos Para Guardar P1:"+ pos +".";
         jugador=2;
         y = pos;


      } 
      
      else 
    
      if (posglobalp1 > 99 ){
          alert("EL juego ha terminado  Ganador Player 1");
        }
     }
        else if(jugador===2)
        {
          jugando.innerHTML = "Jugando"+ jugador +".";
          status2.innerHTML = "Puntos Para Guardar P2"+ pos2 +"."; ///numero de dado
          var d3 = Math.floor(Math.random() * 6) + 1;
          var d4 = Math.floor(Math.random() * 6) + 1;
           pos2 = y2 + d3 + d4;
   
          status2.innerHTML = "Puntos Para Guardar:"+ pos2 +".";
          dado3.innerHTML =  `<img src= "${dadosimg[d3 - 1]}">`
          dado4.innerHTML =  `<img src= "${dadosimg[d4 - 1]}">`
         
          if(d3 === d4) {
            alert("Dados Dados en Par Para Jugador2  Cambio a Jugador 1");
            pos2=0;
            y2=0;
            status2.innerHTML = "Puntos Para Guardar:"+ pos2 +".";
            posglobalp2 =posglobalp2+pos2;
           status2.innerHTML = "Puntos Para Guardar:"+ pos2 +".";
        jugador=1;     
        jugando.innerHTML = "Jugando"+ jugador +".";
          }
          y2 = pos2;
          if (posglobalp2 > 99){
            alert("EL juego ha terminado Ganador Player 2");
        
        
        }
      }
    }