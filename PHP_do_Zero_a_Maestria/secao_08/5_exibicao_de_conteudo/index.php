<?php

    $nome = "Guilherme";

?>

<form action="">
    <div>
        <!-- ?= $nome; ? é o mesmo que echo $nome; OBS ele imprimi conteúdo mas não guarda valores, não é para usar na lógica php apenas para exibir conteúdo-->
        <input type="text" value="<?= $nome; ?>">
    </div>
    <div>
        <input type="submit" value="Enviar">
    </div>
</form>