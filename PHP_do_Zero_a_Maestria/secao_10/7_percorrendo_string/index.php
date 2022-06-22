<?php

    $str = "Esta é uma string muito grande, ela tem vários caracteres";

    for ($i = 0; $i < strlen($str); $i++) {

        echo "$str[$i] <br>";

    }

    //Erro pelo encode.
    //Saída
    /*
    E
    s
    t
    a

    �
    �

    u
    m
    a

    s
    t
    r
    i
    n
    g

    m
    u
    i
    t
    o

    g
    r
    a
    n
    d
    e
    ,

    e
    l
    a

    t
    e
    m

    v
    �
    �
    r
    i
    o
    s

    c
    a
    r
    a
    c
    t
    e
    r
    e
    s
    */
?>