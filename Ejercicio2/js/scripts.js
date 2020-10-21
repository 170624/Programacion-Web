function doSum() {

    var inputSum1 = document.getElementById('inputSum1');
    var inputSum2 = document.getElementById('inputSum2');

    var result = Number(inputSum1.value) + Number(inputSum2.value);
    // console.log(result);

    var lblSumResult = document.getElementById('lblSumResult');
    lblSumResult.innerHTML = `The result is: ${result}`;
}
function doRes() {

    var inputRes1 = document.getElementById('inputRes1');
    var inputRes2 = document.getElementById('inputRes2');

    var result = Number(inputRes1.value) - Number(inputRes2.value);
    // console.log(result);

    var lblResResult = document.getElementById('lblResResult');
    lblResResult.innerHTML = `The result is: ${result}`;
}
function doMul() {

    var inputMul1 = document.getElementById('inputMul1');
    var inputMul2 = document.getElementById('inputMul2');

    var result = Number(inputMul1.value) * Number(inputMul2.value);
    // console.log(result);

    var lblMulResult = document.getElementById('lblMulResult');
    lblMulResult.innerHTML = `The result is: ${result}`;
}
function doDiv() {

    var inputDiv1 = document.getElementById('inputDiv1');
    var inputDiv2 = document.getElementById('inputDiv2');

    var result = Number(inputDiv1.value) / Number(inputDiv2.value);
    // console.log(result);

    var lblDivResult = document.getElementById('lblDivResult');
    lblDivResult.innerHTML = `The result is: ${result}`;
}
function porcentaje() {

    var inputPorcentaje1 = document.getElementById('inputPorcentaje1');
    var inputPorcentaje2 = document.getElementById('inputPorcentaje2');

    var result = Number(inputPorcentaje1.value) * Number(inputPorcentaje2.value)/100;
    // console.log(result);

    var lblPorcentajeResult = document.getElementById('lblPorcentajeResult');
    lblPorcentajeResult.innerHTML = `The result is: ${result}`;
}