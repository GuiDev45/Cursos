<?php

$a = 1;
$b = "1";

if ($a != $b) {
    echo "A é diferente de B 1 <br>";
}

if ($a !== $b) {
    echo "A é diferente de B 2 <br>";
}

if (1 !== 2) {
    echo "A é diferente de B 3 <br>";
}

if (1 !== "1") {
    echo "A é diferente de B 4 <br>";//É diferente
}

if (1 !== 1) {
    echo "A é diferente de B 5 <br>";//Não é diferente
}

//Saída
/*
A é diferente de B 2
A é diferente de B 3
A é diferente de B 4
*/

?>