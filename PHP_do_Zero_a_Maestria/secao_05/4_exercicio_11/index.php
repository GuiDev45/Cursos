<?php

$x = "5" * 12; //60
echo $x;

echo "<br>";

echo gettype($x); //integer
echo "<br>";
echo gettype([]); //array
echo "<br>";
echo gettype(12.2); //double
echo "<br>";
echo gettype("teste"); //string
echo "<br>";

//Saída
/*
60
integer
array
double
string
*/

?>