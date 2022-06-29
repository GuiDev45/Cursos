<?php

    $host = "localhost";
    $user = "root";
    $pass = "";
    $db = "cursophp";

    $conn = new mysqli($host, $user, $pass, $db);

    //ASSUNTO DA AULA
    $sql = "SELECT * FROM itens"; //Variável $sql recebeu a query SELECT

    $result = $conn->query($sql); //conexão query passando o $sql que recebeu o SELECT

    print_r($result); //Imprimindo o resultado

    $conn->close(); //SEMPRE LEMBRAR DE FECHAR A CONEXÃO.

    /*Saída
    mysqli_result Object ( [current_field] => 0 [field_count] => 3 [lengths] => [num_rows] => 0 [type] => 0 )
    */
?>