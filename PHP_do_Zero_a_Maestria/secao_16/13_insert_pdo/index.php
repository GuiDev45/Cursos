<?php
//PDO (PHP Data Object) é uma extensão da linguagem PHP para acesso a banco de dados. Totalmente orientado a objetos

    //Essa é a forma de se conectar com o banco usando o PDO.
    $host = "localhost";
    $db = "cursophp";
    $user = "root";
    $pass = "";

    $conn = new PDO("mysql:host=$host;dbname=$db", $user, $pass);

    //ASSUNTO DA AULA
    $stmt = $conn->prepare("INSERT INTO itens (nome, descricao) VALUES (:nome, :descricao)");

    //É o certo passar os parametros por referencia e não direta.
    $nome = "Suporte monitor";
    $descricao = "O suporte está novo e na caixa ainda.";

    $stmt->bindParam(":nome", $nome);
    $stmt->bindParam(":descricao", $descricao);

    $stmt->execute();