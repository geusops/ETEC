<?php require_once('cabecalho.php'); ?>
<div class="w3-padding w3-content w3-text-grey w3-third w3-display-middle">
    <?php
        require_once 'conexaoBD.php';
        $sql = "DELETE FROM livraria WHERE idlivro = '".$_POST['txtID'] ."';";
        if ($conexao->query($sql) === TRUE) {
            echo '
            <a href="listar.php">
                <h1 class="w3-button w3-brown">Livro excluido com sucesso! </h1>
            </a> 
            ';
        } else {
            echo '
            <a href="listar.php">
                <h1 class="w3-button w3-brown">ERRO! </h1>
            </a> 
            ';
        }
        $conexao->close();
    ?>
</div>





</body>
</html>