<?php

    $host = "localhost";
    $user = "root";
    $pass = "";
    $db = "cursophp";

    $conn = new mysqli($host, $user, $pass, $db);

    //ASSUNTO DA AULA

    $id = 1;

    $stmt = $conn->prepare("SELECT * FROM itens WHERE id = ?");

    $stmt->bind_param("i", $id); //Estou dizende que esse id é um integer

    $stmt->execute();

    $result = $stmt->get_result();

    $item = $result->fetch_row(); //Uma linha

    print_r($item);

    $conn->close();

    /*Saída
    Array ( [0] => 1 [1] => Xícara [2] => É uma xícara usada de cor rosa )
    */