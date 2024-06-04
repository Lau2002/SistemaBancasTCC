<script setup lang="ts">

</script>

<template>
   <body>
        <main>
            <div class="titulo">
                <h1>Registrar TCC</h1>
            </div>
            <form>
                <div class="form-group">
                    <label for="Nome">Título:</label>
                    <input type="text" class="form-control" id="Titulo">
                </div>
                <div class="form-group">
                    <label for="File" class="input-file">Arquivo:</label><br>
                    <input type="file" class="form-control" id="File" accept=".txt">
                </div>
                <div class="input-container">
                    <div class="input-group">
                        <label for="orientador">Orientador</label>
                        <select id="orientador">
                            <option value="" disabled selected>Selecione uma opção</option>
                            <option>Option 1</option>
                            <option>Option 2</option>
                            <option>Option 3</option>
                        </select>
                    </div>
                    <div class="input-group">
                        <label for="avaliador_1">Avaliador 1</label>
                        <select id="avaliador_1">
                            <option value="" disabled selected>Selecione uma opção</option>
                            <option>Option 1</option>
                            <option>Option 2</option>
                            <option>Option 3</option>
                        </select>
                    </div>
                    <div class="input-group">
                        <label for="avaliador_2">Avaliador 2</label>
                        <select id="avaliador_2">
                            <option value="" disabled selected>Selecione uma opção</option>
                            <option>Option 1</option>
                            <option>Option 2</option>
                            <option>Option 3</option>
                        </select>
                    </div>
                    <div class="input-group">
                        <label for="avaliador_3">Avaliador 3</label>
                        <select id="avaliador_3">
                            <option value="" disabled selected>Selecione uma opção</option>
                            <option>Option 1</option>
                            <option>Option 2</option>
                            <option>Option 3</option>
                        </select>
                    </div>
                </div>
                <button type="submit" class="btn btn-primary">Cadastrar</button>
            </form>
        </main>
    </body>
</template>

<style scoped>

.input-container {
    width: fit-content;
  display: grid;
  grid-template-columns: 1fr 1fr; /* Define duas colunas de igual largura */
  grid-gap: 20px; /* Espaço entre os inputs */
  padding-bottom: 30px;
}

.input-group {
  display: flex;
  flex-direction: column; /* Organiza o label e o select em coluna */
}

select {
    height: 40px;
    width: 240px;
    border-color: #989A9D;
    border-radius: 4px;
}
</style>
 