<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>

 < script >
        function multiply() {
    num1 = document.getElementById('Number1').value;
    num2 = document.getElementById('Number2').value;
    document.getElementById('result').innerHTML = num1 * num2;
}
function Divide()
{
    num1 = document.getElementById('Number1').value;
    num2 = document.getElementById('Number2').value;
    document.getElementById('result').innerHTML = num1 / num2;
}
    </ script >
</head>
<body>

 < h3 > 1.Write a JavaScript program to calculate multiplication and division of two numbers (input from user).</ h3 >
      1st Number:< input type = "number" id = "Number1" />< br />< br />
         2nd Number:< input type = "number" id = "Number2" />< br />< br />
        
            < input type = "button" onclick = "multiply()" value = " Multiply" />
             
                 < input type = "button" onclick = "Divide()" value = " Divide" />
                  
                      < p >
                          The Result is : < div id = "result" ></ div >
                   
                       </ p >
                   

                   </body>
</html>