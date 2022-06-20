<p>Testando</p>

<?php

    //Poderia ser tanto include como o require, a diferença é que se tiver erro o require não executa o restante que está abaixo dele.
    //acessando a pasta e o arquivo.
    require "arquivos/funcao.php";

?>

<?php

    //Tanto o require quanto o include são ótimos para reaproveitar códgios php ou templates de sites etc.
    require "teste.php";

    //Além do erro de não achar o arquivo, o programa vai parar, não vai chegar em <p>Arquivo do include</p>
    //Diferente do include, include apenas acusa um warning
    require "teste2.php";

?>

<p>Arquivo do include</p>