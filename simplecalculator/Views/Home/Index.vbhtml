@Code
    ViewData("Title") = "Home Page"
End Code


<style>
    body {
    padding: 0;
    margin: 0;
    background: #333;
    }
    h1 {
      position: absolute;
      top: 2%;
      left: 35%;
      color:#e7e3e3d8;
  
    }
    form {
        margin-left: 35vw;
        margin-top: 20vh;
        width: 300px;
        height: 400px;
        background: #333;
        border-radius: 12px;
        box-shadow: 10px 12px 5px 0px rgba(0,0,0,0.1);
        border-left: 4px solid #656565;
         transition: .6s;
    }

    table {
        padding: 5% 10px;
    }

    #display {
        margin: 15px 10px;
        padding: 10px 4px;
        font-size: 28px;
        width: 250px;
        color: rgb(82, 81, 81);
        border-radius: 5px;
        box-shadow: 2px 5px 5px 0px rgba(255, 255, 255, 0.1);
    }
    input {
      outline: none;
  
    }
    input[type=button] {
        font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
        padding:  0px 0;
        width: 65px;
        height: 65px;
        font-size: 28px;
        color: aliceblue;
        background-color: #333;
        border: none;
        text-decoration: none;
        transition: .6s;
        border-radius: 50%;
    }
    input[type=button]:after:hover {
        font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
        color:  rgb(0, 0, 0);
        background-color:rgba(255, 255, 255, 0.9);
    }
    input[type=button]:hover {
        font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
        color:  rgb(0, 0, 0);
        background-color: #E4E4E1;
     background-image: radial-gradient(at top center, rgba(255,255,255,0.03) 0%, rgba(0,0,0,0.03) 100%), linear-gradient(to top, rgba(255,255,255,0.1) 0%, rgba(143,152,157,0.60) 100%);
  
 	    background-blend-mode: normal, multiply;
        text-decoration: none;
      opacity: .7;
    
    }
</style>

<div class="row">
    <h1>Simple Calculator css</h1>
    <form name="calculator">
        <table>
            <tr>
                <td colspan="4">
                    <input type="text" name="display" id="display" disabled placeholder="0">
                </td>
            </tr>
            <tr>
                <td><input type="button" name="seven" value="7" onclick="calculator.display.value += '7'"></td>
                <td><input type="button" name="eight" value="8" onclick="calculator.display.value += '8'"></td>
                <td><input type="button" name="nine" value="9" onclick="calculator.display.value += '9'"></td>
                <td><input type="button" class="operator" name="times" value="x" onclick="calculator.display.value += '*'"></td>
            </tr>
            <tr>
                <td><input type="button" name="four" value="4" onclick="calculator.display.value += '4'"></td>
                <td><input type="button" name="five" value="5" onclick="calculator.display.value += '5'"></td>
                <td><input type="button" name="six" value="6" onclick="calculator.display.value += '6'"></td>
                <td><input type="button" class="operator" name="minus" value="-" onclick="calculator.display.value += '-'"></td>
            </tr>
            <tr>
                <td><input type="button" name="one" value="1" onclick="calculator.display.value += '1'"></td>
                <td><input type="button" name="two" value="2" onclick="calculator.display.value += '2'"></td>
                <td><input type="button" name="three" value="3" onclick="calculator.display.value += '3'"></td>
                <td><input type="button" class="operator" name="plus" value="+" onclick="calculator.display.value += '+'"></td>
            </tr>
            <tr class="clear">
                <td><input type="button" id="clear" name="clear" value="c" onclick="calculator.display.value = ''"></td>
                <td><input type="button" name="zero" value="0" onclick="calculator.display.value += '0'"></td>
                <td><input type="button" name="doit" value="=" onclick="calculator.display.value = eval(calculator.display.value)"></td>
                <td><input type="button" class="operator" name="div" value="/" onclick="calculator.display.value += '/'"></td>
            </tr>
        </table>
    </form>
</div>
