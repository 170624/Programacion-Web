

  function limpiar(){
    let make = document.getElementById("imake").value;
    let model = document.getElementById("imodel").value;
    let year = document.getElementById("iyear").value;
    imake.value = '';
    imodel.value = '';
    iyear.value = '';
    
  }
  function guardar(){
  
    let make = document.getElementById("imake").value;
    let model = document.getElementById("imodel").value;
    let year = document.getElementById("iyear").value;
        if(make === ''|| model === ''  || year === '') {
          alert("Ingresa todos los campos");
      } 
      else 
      {
        var fila="<tr><td>"+make+"</td><td>"+model +"</td><td>"+year +"</td></tr>";

    let btn = document.createElement("TR");
   	btn.innerHTML=fila;
    document.getElementById("mitabla").appendChild(btn);
      }
}
function borrar(){
  let table = document.getElementById("mitabla");
  let rowCount = table.rows.length;
 
  if(rowCount <= 1)
    alert('Ya no hay mas informacion que borrar');
  else
    table.deleteRow(rowCount -1);
}
function borrartodo(){
  var elmtTable = document.getElementById('mitabla'); 
  var tableRows = elmtTable.getElementsByTagName('tr'); 
  var rowCount = tableRows.length; 
  
  for (var x=rowCount-1; x>0; x--) { 
      elmtTable.removeChild(tableRows[x]); 
  } 
  
}

