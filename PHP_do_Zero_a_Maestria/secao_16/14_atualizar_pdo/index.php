<?php
//PDO (PHP Data Object) é uma extensão da linguagem PHP para acesso a banco de dados. Totalmente orientado a objetos

    //Essa é a forma de se conectar com o banco usando o PDO.
    $host = "localhost";
    $db = "cursophp";
    $user = "root";
    $pass = "";

    $conn = new PDO("mysql:host=$host;dbname=$db", $user, $pass);

    //ASSUNTO DA AULA
    $id = 2;
    $nome = "Teclado Microsoft";
    $descricao = "Este teclado é novo e está na caixa.";

    $stmt = $conn->prepare("UPDATE itens SET nome = :nome, descricao = :descricao WHERE id = :id");

    $stmt->bindParam(":id", $id);
    $stmt->bindParam(":nome", $nome);
    $stmt->bindParam(":descricao", $descricao);

    $stmt->execute();