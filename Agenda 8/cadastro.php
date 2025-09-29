<?php require_once ('verificarAcesso.php');?>
<?php require_once('cabecalho.php'); ?>
<a href="index.php" class="w3-display-topleft">
    <i class="fa fa-arrow-circle-left w3-large w3-brown w3-button w3-xxlarge"></i>     
</a> 
<div class="w3-padding w3-content w3-text-grey w3-third w3-margin w3-display-middle">
        <h1 class="w3-center w3-brown w3-round-large w3-margin">Cadastro de Livros</h1>
        <form action="cadastroAction.php" class="w3-container" method='post'>
            <label class="w3-text-white w3-text-shadow" style="font-weight: bold;">Código</label>
            <input name="txtID" class="w3-input w3-grey w3-border" disabled><br>
            <label class="w3-text-white w3-text-shadow" style="font-weight: bold;">Nome</label>
            <input name="txtNome" class="w3-input w3-light-grey w3-border"><br>
            <label class="w3-text-white w3-text-shadow" style="font-weight: bold;">Autor</label>
            <input name="txtAutor" class="w3-input w3-light-grey w3-border"><br>
            <label class="w3-text-white w3-text-shadow" style="font-weight: bold;">Editora</label>
            <input name="txtEditora" class="w3-input w3-light-grey w3-border"><br>
            <label class="w3-text-white w3-text-shadow w3-text-shadow" style="font-weight: bold;">Quantidade de páginas</label>
            <input name="txtPag" class="w3-input w3-light-grey w3-border"><br>
            <button name="btnAdicionar" class="w3-button w3-brown w3-cell w3-round-large w3-right w3-margin-right"> 
                <i class="w3-xxlarge fa fa-user-plus"></i> Adicionar
            </button>
        </form>
</div>




</body>
</html>