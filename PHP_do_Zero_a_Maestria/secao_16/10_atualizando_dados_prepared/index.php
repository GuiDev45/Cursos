<?php

    $host = "localhost";
    $user = "root";
    $pass = "";
    $db = "cursophp";

    $conn = new mysqli($host, $user, $pass, $db);

    //ASSUNTO DA AULA

    $id = 3;

    $stmt = $conn->prepare("UPDATE itens SET nome = ?, descricao = ? WHERE id = ?");

    $nome = "sofá";
    $descricao = "Sofá semi novo, com madeira de demolição";

    $stmt->bind_param("ssi", $nome, $descricao, $id); // tem 2 strings nome e descricao e 1 int que é o id.

    $stmt->execute();

    //Testando se o stmt deu erro.
    if ($stmt->error) {
        echo "Erro: " . $stmt->error; //Vai imprimir o erro.
    }
