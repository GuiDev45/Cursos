<?php

    //É possível passar os dados em variáveis.
    $host = "localhost";
    $user = "root";
    $pass = "";
    $db = "cursophp";

    //Essa é a forma para se conectar ao banco de dados.
    //Essa forma é melhor que passar os dados diretos.
    $conn = new mysqli($host, $user, $pass, $db);

?>