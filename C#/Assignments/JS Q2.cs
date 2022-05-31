// JavaScript source code
function Check_Num(x, y) {
    if ((x >= 50 && x <= 99) && (y >= 50 && y <= 99)) {
        return true;
    }
    else {
        return false;
    }
}
document.writeln("Check_Num(10, 30)" + " " + Check_Num(10, 30));
document.write("<br>");
document.writeln("Check_Num(18, 95)" + " " + Check_Num(18, 95));
document.write("<br>");
document.writeln("Check_Num(50, 90)" + " " + Check_Num(50, 90));
