<?php

    $host = "localhost";
    $user = "root";
    $pass = "";
    $db = "cursophp";

    $conn = new mysqli($host, $user, $pass, $db);

    //ASSUNTO DA AULA

    $id = 2;

    $stmt = $conn->prepare("SELECT * FROM itens WHERE id > ?");

    $stmt->bind_param("i", $id); //Estou dizende que esse id é um integer

    $stmt->execute();

    $result = $stmt->get_result();

    $data = $result->fetch_all();

    print_r($data);

    /*Saída
    Array ( [0] => Array ( [0] => 3 [1] => Suporte de microfone [2] => O suporte é novo e foi fabricado na China ) )
    */