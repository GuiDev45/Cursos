<?php

    //É possível passar os dados em variáveis.
    $host = "localhost";
    $user = "root";
    $pass = "";
    $db = "cursophp";

    //Essa é a forma para se conectar ao banco de dados.
    //Essa forma é melhor que passar os dados diretos.
    $conn = new mysqli($host, $user, $pass, $db);

    //Imprime um erro de conexão mais elegante, não mostrando o WARNING para o usuário.
    if ($conn->connect_errno) {
        echo "Erro na conexão! <br>";
        echo "Erro: " . mysqli_connect_error();
    }

    if ($conn->connect_errno) {
        echo "Erro na conexão! <br>";
        echo "Erro: " . $conn->connect_error; //Essa é a forma POO para tratar o erro.
    }

?>