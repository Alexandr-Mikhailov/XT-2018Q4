document.getElementById('calculateButton').onclick = function () {
    var str = document.getElementById('input').value;
    var isStrExpression = str.match(/^((\d?\.?\d?\s?\+?\-?\*?\/?)+={1})$/g);

    if (isStrExpression == null || isStrExpression.length !=1) {
        alert("cannot parse arithmetic expression")
    }
    else{
        var expressionParse = str.match(/(\d+(\.*\d)*)|(\+|\-|\*|\/)/g);
    var i, result = 0;

    for (i = 0; i < expressionParse.length; i++){
        switch (expressionParse[i]){
            case '+': {
                result += parseFloat(expressionParse[i+1]);
                i++;
                break;
            }
            case '-': {
                result -= parseFloat(expressionParse[i+1]);
                i++;
                break;
            }
            case '*': {
                result *= parseFloat(expressionParse[i+1]);
                i++;
                break;
            }
            case '/': {
                result /= parseFloat(expressionParse[i+1]);
                i++;
                break;
            }
            default : {
                result = parseFloat(expressionParse[i]);
                break;
            }
        }
    }

    alert(result.toFixed(2));
    }
}